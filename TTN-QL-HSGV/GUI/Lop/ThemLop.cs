using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.GUI.HocSinh;
using TTN_QL_HSGV.GUI.GiaoVien;
using TTN_QL_HSGV.BUS;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.GUI.Lop
{
    public partial class ThemLop : Form
    {
        LopBUS Lbus;
        HocSinhBUS HSbus;
        GiaoVienBUS GVbus;
        List<DTO.HocSinh> hocSinhs;
        public ThemLop()
        {
            InitializeComponent();
            Lbus = new LopBUS();
            HSbus = new HocSinhBUS();
            GVbus = new GiaoVienBUS();
            hocSinhs = new List<DTO.HocSinh>();
        }

        // tên với giới tính vẫn là dạng lọc
        // list gv và khóa học cần thêm  "thêm mới"
        // khi click vào thêm mới thì ra 2 form thêm mưới gv và khóa học
        // khóa học ở form phụ

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            //Truyền mã lớp qua đây, muốn biết chi tiết thì qua form bên dưới 
            ThemHocSinh formTMHS = new ThemHocSinh();
            formTMHS.FormClosed += FormTMHS_FormClosed;
            formTMHS.Show();
            hocSinhs = HSbus.XemTatCaHS();
            dataGridViewDS_HS.DataSource = hocSinhs;
            AddCotCheckbox();
        }

        private void FormTMHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void buttonChiTietHS_Click(object sender, EventArgs e)
        {
            //Truyền mã hs qua đây để xem chi tiết 
            //yêu cầu nút chi tiết chỉ bật khi có 1 dòng được chọn trên datagrv
            this.Hide();
            ThongTinHocSinh formTTHS = new ThongTinHocSinh(dataGridViewDS_HS.CurrentRow.Cells[0].Value.ToString());
            formTTHS.FormClosed += FormTTHS_FormClosed;
            formTTHS.Show();
        }

        private void FormTTHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTietGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            string[] info = comboBoxGVCN.Text.Split(':');
            string maGV = info[0];
            ThongTinGiaoVien formTTGV = new ThongTinGiaoVien(maGV);
            formTTGV.FormClosed += FormTTGV_FormClosed;
            formTTGV.Show();
        }

        private void FormTTGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void ThemLop_Load(object sender, EventArgs e)
        {
            List<string> khoaHocs = Lbus.GetDanhSachKhoaHoc();
            khoaHocs.Add("Thêm khoá học");
            comboBoxKhoaHoc.DataSource = khoaHocs;
            hocSinhs = HSbus.XemTatCaHS();
            dataGridViewDS_HS.DataSource = hocSinhs;
            AddCotCheckbox();
            comboBoxGVCN.DataSource = GVbus.XemDanhSachTenGV();
        }

        private void AddCotCheckbox()
        {
            DataGridViewCheckBoxColumn boxColumn = new DataGridViewCheckBoxColumn();
            boxColumn.ValueType = typeof(bool);
            boxColumn.Name = "Checkbox";
            boxColumn.HeaderText = "Thêm";
            dataGridViewDS_HS.Columns.Add(boxColumn);
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            try
            {
                string[] info = comboBoxGVCN.Text.Split(':');
                string maGV = info[0];
                string malop = Lbus.ThemLop(textBoxLop.Text, maGV, comboBoxKhoaHoc.Text);
                foreach (DataGridViewRow row in dataGridViewDS_HS.Rows)
                {
                    if (row.Cells["Checkbox"].Value != null && (bool)row.Cells["Checkbox"].Value)
                    {
                        HSbus.SuaHS(new DTO.HocSinh(row.Cells["MaHS"].Value.ToString(), row.Cells["TenHS"].Value.ToString(), row.Cells["DiaChi"].Value.ToString(), row.Cells["GioiTinh"].Value.ToString(), row.Cells["Sdt"].Value.ToString(), malop));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm lớp");
            }
        }

        private void dataGridViewDS_HS_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string strColumnName = dataGridViewDS_HS.Columns[e.ColumnIndex].Name;
                SortOrder strSortOrder = getSortOrder(e.ColumnIndex);
                hocSinhs.Sort(new HocSinhComparer(strColumnName, strSortOrder));
                dataGridViewDS_HS.DataSource = null;
                dataGridViewDS_HS.DataSource = hocSinhs;
                dataGridViewDS_HS.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
            }
            catch (Exception ex)
            {

            }
        }
        private SortOrder getSortOrder(int columnIndex)
        {
            try
            {
                if (dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                     dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
                {
                    dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    return SortOrder.Ascending;
                }
                else
                {
                    dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    return SortOrder.Descending;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sắp xếp cột này");
                return SortOrder.None;
            }
        }
        public void GoiKhoaHoc()
        {
            this.Hide();
            KhoaHoc khoaHoc = new KhoaHoc();
            khoaHoc.FormClosed += KhoaHoc_FormClosed;
            khoaHoc.Show();
        }

        private void KhoaHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            
        private void comboBoxKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxKhoaHoc.Text == "Thêm khoá học")
            {
                comboBoxKhoaHoc.SelectedIndex = 0;
                GoiKhoaHoc();
            }    
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.BUS;
using TTN_QL_HSGV.GUI.HocSinh;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.GUI.Lop
{
    public partial class ThemHocSinhVaoLop : Form
    {
        private string MaLop;
        LopBUS Lbus;
        HocSinhBUS HSbus;
        List<DTO.HocSinh> hocSinhs;
        public ThemHocSinhVaoLop(string Ma)
        {
            //lấy mã lớp sang đây để sửa mã lớp cho học sinh sau khi chọn 
            MaLop = Ma;

            InitializeComponent();
            Lbus = new LopBUS();
            HSbus = new HocSinhBUS();
            hocSinhs = new List<DTO.HocSinh>();
        }

        // phần lọc lấy danh sách từ database ra add dưới dạng list<A> thêm 'None' vào 
        // để mặc định hiển thị 'None' khi chọn mục này thì bỏ qua đk lọc

        // datagrv ở form này yêu cầu ghép thêm checkbox để tích chọn học sinh 

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //lấy id bằng cách chọn 1 dòng trong datagrv xong truyền qua form bên kia
            //nút chi tiết cần chỉ bật khi đang chọn 1 dòng trong datagrv nếu không chọn dòng nào thì để tắt
            this.Hide();
            ThongTinHocSinh formTTHS = new ThongTinHocSinh(hocSinhs[dataGridViewDS_HS.CurrentCell.RowIndex].MaHS.ToString());
            formTTHS.FormClosed += FormTTHS_FormClosed;
            formTTHS.Show();
        }

        private void FormTTHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridViewDS_HS.Columns.Remove("Checkbox");
            hocSinhs = HSbus.XemTatCaHS();
            dataGridViewDS_HS.DataSource = null;
            dataGridViewDS_HS.DataSource = hocSinhs;
            AddCotCheckbox();
            CheckHocSinh();
            this.Show();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHocSinh formTMHS = new ThemHocSinh();
            formTMHS.FormClosed += FormTMHS_FormClosed;
            formTMHS.Show();
        }

        private void FormTMHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void ThemHocSinhVaoLop_Load(object sender, EventArgs e)
        {
            List<string> lops = Lbus.GetDanhSachLopString();
            lops.Insert(0, "None");
            comboBoxLop.DataSource = lops;
            comboBoxGioiTinh.SelectedIndex = 0;
            hocSinhs = HSbus.XemTatCaHS();
            dataGridViewDS_HS.DataSource = hocSinhs;
            AddCotCheckbox();
            CheckHocSinh();
        }

        private void CheckHocSinh()
        {
            foreach (DataGridViewRow row in dataGridViewDS_HS.Rows)
            {
                if (row.Cells["MaLop"].Value.ToString() == MaLop)
                {
                    DataGridViewCheckBoxCell boxCell = (DataGridViewCheckBoxCell)row.Cells["Checkbox"];
                    boxCell.Value = true;
                    boxCell.ReadOnly = true;
                }
            }
        }

        private void AddCotCheckbox()
        {
            DataGridViewCheckBoxColumn boxColumn = new DataGridViewCheckBoxColumn();
            boxColumn.ValueType = typeof(bool);
            boxColumn.Name = "Checkbox";
            boxColumn.HeaderText = "Thêm";
            dataGridViewDS_HS.Columns.Add(boxColumn);
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            if (comboBoxGioiTinh.Text == "None" && comboBoxLop.Text == "None")
            {
                hocSinhs = HSbus.XemTatCaHS();
                dataGridViewDS_HS.DataSource = hocSinhs;
            }
            else if (comboBoxGioiTinh.Text == "None" && comboBoxLop.Text != "None")
            {
                hocSinhs = HSbus.XemTatCaHSLop(comboBoxLop.Text);
                dataGridViewDS_HS.DataSource = hocSinhs;
            }
            else if (comboBoxGioiTinh.Text != "None" && comboBoxLop.Text == "None")
            {
                hocSinhs = HSbus.XemTatCaHSGT(comboBoxGioiTinh.Text);
                dataGridViewDS_HS.DataSource = hocSinhs;
            }
            else if (comboBoxGioiTinh.Text != "None" && comboBoxLop.Text != "None")
            {
                hocSinhs = HSbus.XemTatCaHSLopGT(comboBoxLop.Text, comboBoxGioiTinh.Text);
                dataGridViewDS_HS.DataSource = hocSinhs;
            }
            CheckHocSinh();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDS_HS.Rows)
            {
                if (row.Cells["Checkbox"].Value != null && (bool)row.Cells["Checkbox"].Value)
                {
                    HSbus.SuaHS(new DTO.HocSinh(row.Cells["MaHS"].Value.ToString(), row.Cells["TenHS"].Value.ToString(), row.Cells["DiaChi"].Value.ToString(), row.Cells["GioiTinh"].Value.ToString(), row.Cells["Sdt"].Value.ToString(), MaLop));
                }
            }
            MessageBox.Show("Xong");
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show("Không thể sắp xếp cột này");
                return SortOrder.None;
            }
        }
    }
}

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
using TTN_QL_HSGV.DTO;
using TTN_QL_HSGV.GUI.Lop;

namespace TTN_QL_HSGV.GUI.Lop
{
    public partial class DanhSachLop : Form
    {
        LopBUS bus;
        List<DTO.Lop> lops;
        public DanhSachLop()
        {
            InitializeComponent();
            bus = new LopBUS();
            lops = new List<DTO.Lop>();
        }

        // phần lọc lấy danh sách từ database ra add dưới dạng list<A> thêm 'None' vào 
        // để mặc định hiển thị 'None' khi chọn mục này thì bỏ qua đk lọc

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //lấy id bằng cách chọn 1 dòng trong datagrv xong truyền qua form bên kia
            //nút chi tiết cần chỉ bật khi đang chọn 1 dòng trong datagrv nếu không chọn dòng nào thì để tắt
            this.Hide();
            ThongTinLop formTTL = new ThongTinLop("1");
            formTTL.FormClosed += FormTTL_FormClosed;
            formTTL.Show();
        }

        private void FormTTL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemLop formTL = new ThemLop();
            formTL.FormClosed += FormTL_FormClosed;
            formTL.Show();
        }

        private void FormTL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            dataGridViewDS_Lop.DataSource = bus.GetDanhSachLop();
            textBoxtenGVCN.Text = bus.GetTenGiaoVien(dataGridViewDS_Lop.CurrentRow.Cells[0].Value.ToString());
            comboBoxKhoaHoc.DataSource = bus.GetDanhSachKhoaHoc();
        }

        private void dataGridViewDS_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxtenGVCN.Text = bus.GetTenGiaoVien(dataGridViewDS_Lop.CurrentRow.Cells[0].Value.ToString());
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            if (comboBoxKhoaHoc.Text == "None")
            {
                dataGridViewDS_Lop.DataSource = bus.GetDanhSachLop();
            }
            else
            {
                dataGridViewDS_Lop.DataSource = bus.GetDanhSachLop(comboBoxKhoaHoc.Text);
            }
        }

        private void dataGridViewDS_Lop_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dataGridViewDS_Lop.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = getSortOrder(e.ColumnIndex);
            hocSinhs.Sort(new HocSinhComparer(strColumnName, strSortOrder));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hocSinhs;
            dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }
    }
}

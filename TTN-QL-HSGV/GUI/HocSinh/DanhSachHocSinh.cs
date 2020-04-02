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

namespace TTN_QL_HSGV.GUI.HocSinh
{
    public partial class DanhSachHocSinh : Form
    {
        private static DataGridView dths;
        private static TextBox textboxSoLuongHS;
        string maHS;
        public static DataGridView Dths { get => dths; set => dths = value; }
        public static TextBox TextboxSoLuongHS { get => textboxSoLuongHS; set => textboxSoLuongHS = value; }

        public DanhSachHocSinh()
        {

            InitializeComponent();

            dths = dataGridViewDS_HS;

            textboxSoLuongHS = textBoxTongSo;

            buttonChiTiet.Enabled = false;

            DataTable dtLop = controllerHS.XemTatCaLopHoc();
            dtLop.Rows.Add(new Object[] { "None", "None" });
            comboBoxLop.DataSource = dtLop;
            comboBoxLop.DisplayMember = "TenLop";
            comboBoxLop.ValueMember = "MaLop";

            DataTable dtKhoaHoc = controllerHS.XemTatCaKhoaHoc();
            dtKhoaHoc.Rows.Add(new Object[] { "None", "None" });
            comboBoxKhoaHoc.DataSource = dtKhoaHoc;
            comboBoxKhoaHoc.DisplayMember = "TenKH";
            comboBoxKhoaHoc.ValueMember = "MaKH";

            comboBoxGioiTinh.SelectedItem = "None";
            comboBoxLop.SelectedValue = "None";
            comboBoxKhoaHoc.SelectedValue = "None";
        }

        HocSinhBUS controllerHS = new HocSinhBUS();
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
            ThongTinHocSinh formTTHS = new ThongTinHocSinh(maHS);
            formTTHS.FormClosed += FormTTHS_FormClosed;
            formTTHS.Show();
        }

        private void FormTTHS_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            this.Show(); ;
        }

        private void DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            dataGridViewDS_HS.DataSource = controllerHS.XemTatCaHS();
            dataGridViewDS_HS.Refresh();

            this.KeyPreview = true;

            textBoxTongSo.Text = dataGridViewDS_HS.Rows.Count.ToString();
        }

        private void DataGridViewDS_HS_Click(object sender, EventArgs e)
        {
            if (dataGridViewDS_HS.Rows.Count == 0)
            {
                MessageBox.Show("Hãy thêm học sinh mới");
            }
            else
            {
                int index = dataGridViewDS_HS.SelectedRows[0].Index;

                maHS = dataGridViewDS_HS.Rows[index].Cells["MaHS"].Value.ToString();

                buttonChiTiet.Enabled = true;
            }
        }

        private void ButtonLoc_Click(object sender, EventArgs e)
        {
            string gt = comboBoxGioiTinh.SelectedItem.ToString();
            string lop = comboBoxLop.SelectedValue.ToString();
            string khoahoc = comboBoxKhoaHoc.SelectedValue.ToString();

            List<DTO.HocSinh> dsHocSinh = controllerHS.XemTatCaHS();
            List<DTO.HocSinh> items = dsHocSinh;
            if (gt != "None")
            {
                items = dsHocSinh.FindAll(item => item.GioiTinh == gt);
            }
            if (lop != "None")
            {
                items = items.FindAll(item => item.MaLop == lop);
            }
            //if (khoahoc != "None")
            //{
            //    items = items.FindAll(item => item.khoa == khoahoc);
            //}
            
            dataGridViewDS_HS.DataSource = items;
            dataGridViewDS_HS.Refresh();
        }
    }
}

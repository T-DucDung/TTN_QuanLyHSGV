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
using TTN_QL_HSGV.GUI.GiaoVien;

namespace TTN_QL_HSGV.GUI.GiaoVien
{
    public partial class DanhSachGiaoVien : Form
    {
        private static DataGridView dtgv;
        private static TextBox textboxSoLuong;
        string maGV;
        public static DataGridView Dtgv { get => dtgv; set => dtgv = value; }
        public static TextBox TextboxSoLuong { get => textboxSoLuong; set => textboxSoLuong = value; }

        public DanhSachGiaoVien()
        {
            InitializeComponent();

            dtgv = dataGridViewDS_GV;

            textboxSoLuong = textBoxTongSo;

            buttonChiTiet.Enabled = false;

            DataTable dt = controllerGV.XemTatCaMonHoc();
            dt.Rows.Add(new Object[] { "None", "None" });


            comboBoxMon.DataSource = dt;
            comboBoxMon.DisplayMember = "TenMon";
            comboBoxMon.ValueMember = "MaMon";

            comboBoxGioiTinh.SelectedItem = "None";
            comboBoxChucVu.SelectedItem = "None";
            comboBoxMon.SelectedValue = "None";
        }

        GiaoVienBUS controllerGV = new GiaoVienBUS();
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
            ThongTinGiaoVien formTTGV = new ThongTinGiaoVien(maGV);
            formTTGV.FormClosed += FormTTGV_FormClosed;
            formTTGV.Show();
        }

        private void FormTTGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemGiaoVien formTMGV = new ThemGiaoVien();
            formTMGV.FormClosed += FormTMGV_FormClosed;
            formTMGV.Show();
        }

        private void FormTMGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void DataGridViewDS_GV_Click(object sender, EventArgs e)
        {
            if (dataGridViewDS_GV.Rows.Count == 0)
            {
                MessageBox.Show("Hãy thêm giáo viên mới");
            }
            else
            {
                int index = dataGridViewDS_GV.SelectedRows[0].Index;

                maGV = dataGridViewDS_GV.Rows[index].Cells["MaGV"].Value.ToString();

                buttonChiTiet.Enabled = true;
            }
        }

        private void DanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            dataGridViewDS_GV.DataSource = controllerGV.XemTatCaGV();
            dataGridViewDS_GV.Refresh();

            this.KeyPreview = true;

            textBoxTongSo.Text = dataGridViewDS_GV.Rows.Count.ToString();
        }

        private void ButtonLoc_Click(object sender, EventArgs e)
        {
            string gt = comboBoxGioiTinh.SelectedItem.ToString();
            string chucvu = comboBoxChucVu.SelectedItem.ToString();
            string mon = comboBoxMon.SelectedValue.ToString();

            List<DTO.GiaoVien> dsGiaoVien = controllerGV.XemTatCaGV();
            List<DTO.GiaoVien> items = dsGiaoVien;
            if (gt != "None")
            {
                items = dsGiaoVien.FindAll(item => item.GioiTinh == gt);
            }
            if(chucvu != "None")
            {
                items = items.FindAll(item => item.ChucVu == chucvu);
            }
            if (mon != "None")
            {
                items = items.FindAll(item => item.MaMon == mon);
            }

            dataGridViewDS_GV.DataSource = items;
            dataGridViewDS_GV.Refresh();
        }
    }
}

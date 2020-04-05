using System;
using System.Windows.Forms;
using TTN_QL_HSGV.BUS;

namespace TTN_QL_HSGV.GUI.GiaoVien
{
    public partial class ThongTinGiaoVien : Form
    {
        //ID sử dụng truy xuất và sửa thông tin
        private string ID;
        public ThongTinGiaoVien(string IDGiaoVien)
        {
            ID = IDGiaoVien;

            InitializeComponent();

            comboBoxDayMon.DataSource = controllerGV.XemTatCaMonHoc();
            comboBoxDayMon.DisplayMember = "TenMon";
            comboBoxDayMon.ValueMember = "MaMon";
        }

        GiaoVienBUS controllerGV = new GiaoVienBUS();
        // lấy thông tin lên form riêng phần môn thì truy xuất danh sách mã sang tên để chọn 
        // sử dụng các hàm viết trong BUS
        // thiếu thì viết thêm tuyệt đối không được sửa trong DAL
        // combox lấy data từ base lên add vào list rồi chọn datasource là list đó
        // thêm vào list vị trí cuối cùng là 'thêm mới' rồi xử lý chọn dòng đấy để gọi 1 form mới tương ứng

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            DTO.GiaoVien gv = new DTO.GiaoVien();

            gv.MaGV = ID;
            gv.TenGV = textBoxTenGV.Text;
            gv.ChucVu = textBoxChucVu.Text;
            gv.GioiTinh = textBoxGT.Text;
            gv.DiaChi = textBoxDiaChi.Text;
            gv.Sdt = textBoxSDT.Text;
            gv.MaMon = comboBoxDayMon.SelectedValue.ToString();

            if (controllerGV.SuaGV(gv))
            {
                MessageBox.Show("Sửa thành công");

                DanhSachGiaoVien.Dtgv.DataSource = controllerGV.XemTatCaGV();
                DanhSachGiaoVien.Dtgv.Refresh();
            }
            else MessageBox.Show("Sửa thất bại");
        }

        private void ThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            DTO.GiaoVien giaoVien = controllerGV.XemChiTietGV(ID);
            textBoxTenGV.Text = giaoVien.TenGV;
            textBoxDiaChi.Text = giaoVien.DiaChi;
            textBoxChucVu.Text = giaoVien.ChucVu;
            textBoxGT.Text = giaoVien.GioiTinh;
            textBoxSDT.Text = giaoVien.Sdt;
            comboBoxDayMon.SelectedValue = giaoVien.MaMon.ToString();
            pictureBox1.Image = controllerGV.XemAnhGV(ID);
        }

        

        private void MonHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonThemMon_Click(object sender, EventArgs e)
        {
            GUI.FormPhu.MonHoc monHoc = new FormPhu.MonHoc();
            monHoc.FormClosed += MonHoc_FormClosed;
            monHoc.Show();
            this.Hide();
        }
    }
}

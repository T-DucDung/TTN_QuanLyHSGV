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
            textBoxTenGV.Text = controllerGV.XemChiTietGV(ID).TenGV;
            textBoxDiaChi.Text = controllerGV.XemChiTietGV(ID).DiaChi;
            textBoxChucVu.Text = controllerGV.XemChiTietGV(ID).ChucVu;
            textBoxGT.Text = controllerGV.XemChiTietGV(ID).GioiTinh;
            textBoxSDT.Text = controllerGV.XemChiTietGV(ID).Sdt;
            comboBoxDayMon.SelectedValue = controllerGV.XemChiTietGV(ID).MaMon.ToString();
        }

        private void buttonThemMon_Click(object sender, EventArgs e)
        {
            GUI.FormPhu.MonHoc monHoc = new GUI.FormPhu.MonHoc();
            this.Hide();
            monHoc.FormClosed += MonHoc_FormClosed;
            monHoc.Show();
        }

        private void MonHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

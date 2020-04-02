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

namespace TTN_QL_HSGV.GUI.HocSinh
{
    public partial class ThongTinHocSinh : Form
    {
        //ID sử dụng truy xuất và sửa thông tin
        private string ID;
        public ThongTinHocSinh(string IDHocSinh)
        {
            ID = IDHocSinh;

            InitializeComponent();

            comboBoxThuocLop.DataSource = controllerHS.XemTatCaLopHoc();
            comboBoxThuocLop.DisplayMember = "TenLop";
            comboBoxThuocLop.ValueMember = "MaLop";
        }

        HocSinhBUS controllerHS = new HocSinhBUS();
        // lấy thông tin lên form riêng phần lớp thì truy xuất danh sách mã sang tên để chọn 
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
            DTO.HocSinh hs = new DTO.HocSinh();

            hs.MaHS = ID;
            hs.TenHS = textBoxTenHS.Text;
            hs.GioiTinh = textBoxGT.Text;
            hs.DiaChi = textBoxDiaChi.Text;
            hs.Sdt = textBoxSDT.Text;
            hs.MaLop = comboBoxThuocLop.SelectedValue.ToString();

            if (controllerHS.SuaHS(hs))
            {
                MessageBox.Show("Sửa thành công");

                DanhSachHocSinh.Dths.DataSource = controllerHS.XemTatCaHS();
                DanhSachHocSinh.Dths.Refresh();
            }
            else MessageBox.Show("Sửa thất bại");
        }

        private void ThongTinHocSinh_Load(object sender, EventArgs e)
        {
            textBoxTenHS.Text = controllerHS.XemChiTietHS(ID).TenHS;
            textBoxDiaChi.Text = controllerHS.XemChiTietHS(ID).DiaChi;
            textBoxGT.Text = controllerHS.XemChiTietHS(ID).GioiTinh;
            textBoxSDT.Text = controllerHS.XemChiTietHS(ID).Sdt;
            comboBoxThuocLop.SelectedValue = controllerHS.XemChiTietHS(ID).MaLop.ToString();
        }
    }
}

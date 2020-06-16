using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.BUS;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.GUI.HocSinh
{
    public partial class ThongTinHocSinh : Form
    {
        private byte[] image;
        //ID sử dụng truy xuất và sửa thông tin
        private string ID;
        public ThongTinHocSinh(string IDHocSinh)
        {
            ID = IDHocSinh;

            InitializeComponent();

            comboBoxThuocLop.DataSource = controllerHS.XemTatCaLopHoc();
            comboBoxThuocLop.DisplayMember = "TenLop";
            comboBoxThuocLop.ValueMember = "MaLop";
            image = null;
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
        private void btnSuaAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileDialog.FileName);
                image = (byte[])(new ImageConverter()).ConvertTo(pictureBox1.Image, typeof(byte[]));
            }
            else
            {
                MessageBox.Show("Chưa Chọn Ảnh !!");
            }
        }


        private void ButtonSua_Click(object sender, EventArgs e)
        {
            DTO.HocSinh hs = new DTO.HocSinh();

            hs.MaHS = ID;
            hs.TenHS = textBoxTenHS.Text;
            hs.GioiTinh = textBoxGT.Text.ToUpper();
            hs.DiaChi = textBoxDiaChi.Text;
            hs.Sdt = textBoxSDT.Text;
            hs.MaLop = comboBoxThuocLop.SelectedValue.ToString();

            
            if (image==null)
            {
                if (controllerHS.SuaHS(hs))
                {
                    MessageBox.Show("Sửa thành công");
                    if(DanhSachHocSinh.Dths != null)
                    {
                        DanhSachHocSinh.Dths.DataSource = controllerHS.XemTatCaHS();
                        DanhSachHocSinh.Dths.Refresh();
                    }
                }
                else MessageBox.Show("Sửa thất bại");
            }
            else
            {
                if (controllerHS.SuaHS(hs,image))
                {
                    MessageBox.Show("Sửa thành công");
                    if (DanhSachHocSinh.Dths != null)
                    {
                        DanhSachHocSinh.Dths.DataSource = controllerHS.XemTatCaHS();
                        DanhSachHocSinh.Dths.Refresh();
                    }
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }

        private void ThongTinHocSinh_Load(object sender, EventArgs e)
        {
            DTO.HocSinh hocSinh = controllerHS.XemChiTietHS(ID);
            textBoxTenHS.Text = hocSinh.TenHS;
            textBoxDiaChi.Text = hocSinh.DiaChi;
            textBoxGT.Text = hocSinh.GioiTinh;
            textBoxSDT.Text = hocSinh.Sdt;
            comboBoxThuocLop.SelectedValue = hocSinh.MaLop.ToString();
            pictureBox1.Image = controllerHS.XemAnhHS(ID);
        }

       
    }
}

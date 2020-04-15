using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.BUS;
using System.IO;

namespace TTN_QL_HSGV.GUI.HocSinh
{
    public partial class ThemHocSinh : Form
    {
        private byte[] image;
        public ThemHocSinh()
        {
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

        private void ImageChooseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(fileDialog.FileName);
                image = (byte[])(new ImageConverter()).ConvertTo(pictureBox.Image, typeof(byte[]));
            }
            else
            {
                MessageBox.Show("Chưa Chọn Ảnh !!");
            }
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            bool matchTenHS = Regex.IsMatch(textBoxTenHS.Text, @"^\s");
            bool matchGT = Regex.IsMatch(textBoxGT.Text, @"^\s");
            bool matchSDT = Regex.IsMatch(textBoxSDT.Text, @"^\s");
            bool matchDiaChi = Regex.IsMatch(textBoxDiaChi.Text, @"^\s");
            bool matchLop = Regex.IsMatch(comboBoxThuocLop.Text, @"^\s");

            textBoxTenHS.Text = textBoxTenHS.Text.Trim();
            textBoxGT.Text = textBoxGT.Text.Trim();
            textBoxSDT.Text = textBoxSDT.Text.Trim();
            textBoxDiaChi.Text = textBoxDiaChi.Text.Trim();
            comboBoxThuocLop.Text = comboBoxThuocLop.Text.Trim();

            if (textBoxTenHS.Text == "")
            {
                MessageBox.Show("Tên học sinh không Được Để Trống");
                textBoxTenHS.Focus();
            }
            else if (textBoxGT.Text == "")
            {
                MessageBox.Show("Giới tính không Được Để Trống");
                textBoxGT.Focus();
            }
            else if (textBoxSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không Được Để Trống");
                textBoxSDT.Focus();
            }
            else if (textBoxDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không Được Để Trống");
                textBoxDiaChi.Focus();
            }
            else if (comboBoxThuocLop.Text == "")
            {
                MessageBox.Show("Lớp không Được Để Trống");
                comboBoxThuocLop.Focus();
            }
            else
            {
                if (matchTenHS)
                {
                    MessageBox.Show("Tên học sinh không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxTenHS.Focus();
                }
                else if (matchGT)
                {
                    MessageBox.Show("Giới tính không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxGT.Focus();
                }
                else if (matchSDT)
                {
                    MessageBox.Show("Số điện thoại không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxSDT.Focus();
                }
                else if (matchDiaChi)
                {
                    MessageBox.Show("Địa chỉ không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxDiaChi.Focus();
                }
                else if (textBoxSDT.Text.Length > 11)
                {
                    MessageBox.Show("SDT tối đa chỉ 11 số ");
                    textBoxSDT.Focus();
                }
                else
                {
                    DTO.HocSinh hs = new DTO.HocSinh("0", textBoxTenHS.Text, textBoxDiaChi.Text, textBoxGT.Text, textBoxSDT.Text, comboBoxThuocLop.SelectedValue.ToString());

                    // nam sửa lại theo biến .
                    if (image == null)
                    {
                        if (controllerHS.ThemHS(hs))
                        {
                            MessageBox.Show("Thêm mới thành công");

                            textBoxTenHS.Text = "";
                            textBoxGT.Text = "";
                            textBoxSDT.Text = "";
                            textBoxDiaChi.Text = "";
                            comboBoxThuocLop.SelectedValue = 0;

                            DanhSachHocSinh.Dths.DataSource = controllerHS.XemTatCaHS();
                            DanhSachHocSinh.Dths.Refresh();
                            int i = DanhSachHocSinh.Dths.Rows.Count;
                            DanhSachHocSinh.TextboxSoLuongHS.Text = i.ToString();
                            DanhSachHocSinh.TextboxSoLuongHS.Refresh();
                        }
                        else MessageBox.Show("Thêm mới thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Đang thêm mới");
                        if (controllerHS.ThemHS(hs, image))
                        {
                            MessageBox.Show("Thêm mới thành công");

                            textBoxTenHS.Text = "";
                            textBoxGT.Text = "";
                            textBoxSDT.Text = "";
                            textBoxDiaChi.Text = "";
                            comboBoxThuocLop.SelectedValue = 0;

                            DanhSachHocSinh.Dths.DataSource = controllerHS.XemTatCaHS();
                            DanhSachHocSinh.Dths.Refresh();
                            int i = DanhSachHocSinh.Dths.Rows.Count;
                            DanhSachHocSinh.TextboxSoLuongHS.Text = i.ToString();
                            DanhSachHocSinh.TextboxSoLuongHS.Refresh();
                        }
                        else MessageBox.Show("Thêm mới thất bại");
                    }

                    
                }
            }
        }


    }
}

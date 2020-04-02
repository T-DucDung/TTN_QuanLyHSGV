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

namespace TTN_QL_HSGV.GUI.GiaoVien
{
    public partial class ThemGiaoVien : Form
    {
        public ThemGiaoVien()
        {
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

        private void ThemGiaoVien_Load(object sender, EventArgs e)
        {

        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            bool matchTenGV = Regex.IsMatch(textBoxTenGV.Text, @"^\s");
            bool matchGT = Regex.IsMatch(textBoxGT.Text, @"^\s");
            bool matchChucVu = Regex.IsMatch(textBoxChucVu.Text, @"^\s");
            bool matchSDT = Regex.IsMatch(textBoxSDT.Text, @"^\s");
            bool matchDiaChi = Regex.IsMatch(textBoxDiaChi.Text, @"^\s");
            bool matchDayMon = Regex.IsMatch(comboBoxDayMon.Text, @"^\s");

            textBoxTenGV.Text = textBoxTenGV.Text.Trim();
            textBoxGT.Text = textBoxGT.Text.Trim();
            textBoxChucVu.Text = textBoxChucVu.Text.Trim();
            textBoxSDT.Text = textBoxSDT.Text.Trim();
            textBoxDiaChi.Text = textBoxDiaChi.Text.Trim();
            comboBoxDayMon.Text = comboBoxDayMon.Text.Trim();

            if (textBoxTenGV.Text == "")
            {
                MessageBox.Show("Tên giáo viên không Được Để Trống");
                textBoxTenGV.Focus();
            }
            else if (textBoxGT.Text == "")
            {
                MessageBox.Show("Giới tính không Được Để Trống");
                textBoxGT.Focus();
            }
            else if (textBoxChucVu.Text == "")
            {
                MessageBox.Show("Chức vụ không Được Để Trống");
                textBoxChucVu.Focus();
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
            else if (comboBoxDayMon.Text == "")
            {
                MessageBox.Show("Môn học không Được Để Trống");
                comboBoxDayMon.Focus();
            }
            else
            {
                if (matchTenGV)
                {
                    MessageBox.Show("Tên giáo viên không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxTenGV.Focus();
                }
                else if (matchGT)
                {
                    MessageBox.Show("Giới tính không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxGT.Focus();
                }
                else if (matchChucVu)
                {
                    MessageBox.Show("Chức vụ không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxChucVu.Focus();
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

                    DTO.GiaoVien gv = new DTO.GiaoVien("0", textBoxTenGV.Text, textBoxDiaChi.Text, textBoxGT.Text, textBoxSDT.Text, textBoxChucVu.Text, comboBoxDayMon.SelectedValue.ToString());

                    if (controllerGV.ThemGV(gv))
                    {
                        MessageBox.Show("Thêm mới thành công");

                        textBoxTenGV.Text = "";
                        textBoxGT.Text = "";
                        textBoxChucVu.Text = "";
                        textBoxSDT.Text = "";
                        textBoxDiaChi.Text = "";
                        comboBoxDayMon.SelectedValue = 0;

                        DanhSachGiaoVien.Dtgv.DataSource = controllerGV.XemTatCaGV();
                        DanhSachGiaoVien.Dtgv.Refresh();
                        int i = DanhSachGiaoVien.Dtgv.Rows.Count;
                        DanhSachGiaoVien.TextboxSoLuong.Text = i.ToString();
                        DanhSachGiaoVien.TextboxSoLuong.Refresh();
                    }
                    else MessageBox.Show("Thêm mới thất bại");
                }
            }
        }
    }
}

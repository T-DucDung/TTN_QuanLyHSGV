using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.GUI.GiaoVien;
using TTN_QL_HSGV.GUI.Lop;
using TTN_QL_HSGV.DAL;
using TTN_QL_HSGV.BUS;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace TTN_QL_HSGV.GUI.GiangDay
{
    public partial class ThemGiangDay : Form 
    {
        
        public ThemGiangDay()
        {
            InitializeComponent();
            comboBoxLop.DataSource = GiangDayBUS.GetDanhSachLop();
            comboBoxGiaoVien.DisplayMember = "TenGV";
            comboBoxGiaoVien.ValueMember = "MaGV";
            comboBoxGiaoVien.DataSource = GiangDayBUS.GetDanhSachGiaoVienCaTruong();
            uploaddata();
        }


        #region MyMethods

        public string XoaKiTuTrangOGiua(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf("  ") >= 0)
                {
                    s = s.Replace("  ", " ");
                }
            }
            return s;
        }

        public void uploaddata()
        {
            textBoxMon.Text = DataProvider.Instance.ExecuteScalar("gettenmonhoc '" + comboBoxGiaoVien.SelectedValue.ToString() + "'").ToString();
        }

        public string GhepChuoi(string str)
        {
            string result = "";
            foreach (var item in str)
            {
                if (item != ' ')
                {
                    result += item;
                }
            }
            return result;
        }

        #endregion


        // khi lấy list danh sách đưa lên 2 combobox thì thêm 1 tùy chọn là "thêm mới"
        // nếu ấn chọn cái đấy thì link tới 2 form đó là thêm gv mới và thêm lớp mới

        #region Event

        private void comboBoxGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGiaoVien.SelectedIndex > -1)
            {
                textBoxMon.Text = DataProvider.Instance.ExecuteScalar("gettenmonhoc '" + comboBoxGiaoVien.SelectedValue.ToString() + "'").ToString();
            }
        }

        private void buttonChiTietGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinGiaoVien formTTGV = new ThongTinGiaoVien(comboBoxGiaoVien.SelectedValue.ToString());
            formTTGV.FormClosed += FormTTGV_FormClosed;
            formTTGV.Show();
        }

        private void FormTTGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTietLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinLop formTTL = new ThongTinLop(comboBoxLop.Text,comboBoxGiaoVien.SelectedValue.ToString());
            formTTL.FormClosed += FormTTL_FormClosed;
            formTTL.Show();
        }
        private void FormTTL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonLuu_Click(object sender, EventArgs e)
        {
            bool matchDiaDiem = Regex.IsMatch(textBoxDiaDiem.Text, @"^\s");
            bool matchSoTiet = Regex.IsMatch(textBoxSoTiet.Text, @"^\s");
            bool matchThu = Regex.IsMatch(textBoxThu.Text, @"^\s");
            bool matchTiet = Regex.IsMatch(textBoxTiet.Text, @"^\s");
            bool SoTietisNumBer = Regex.IsMatch(textBoxSoTiet.Text, @"\d");

            textBoxDiaDiem.Text = textBoxDiaDiem.Text.Trim();
            textBoxSoTiet.Text = textBoxSoTiet.Text.Trim();
            textBoxThu.Text = textBoxThu.Text.Trim();
            textBoxTiet.Text = textBoxTiet.Text.Trim();

            textBoxThu.Text = GhepChuoi(textBoxThu.Text);
            textBoxTiet.Text = GhepChuoi(textBoxTiet.Text);

            if (textBoxDiaDiem.Text == "")
            {
                MessageBox.Show("Phải Ghi Rõ Đầy Đủ Thông Tin Địa Điểm Phòng Học!");
                textBoxDiaDiem.Focus();
            }
            else if (textBoxSoTiet.Text == "")
            {
                MessageBox.Show("Số Lượng Tiết Không Được Để Trống");
                textBoxSoTiet.Focus();
            }
            else if (textBoxThu.Text == "")
            {
                MessageBox.Show("Dạy Hôm Nào Vào Thứ Mấy?, Không Được Để Trống");
                textBoxThu.Focus();
            }
            else if (textBoxTiet.Text == "")
            {
                MessageBox.Show("Dạy Vào Tiết Nào?, Không Được Để Trống");
                textBoxTiet.Focus();
            }
            else
            {
                if (matchDiaDiem)
                {
                    MessageBox.Show("Địa Điểm không Được Để Nhiều Khoảng Trắng");
                    textBoxDiaDiem.Focus();
                }
                else if (matchSoTiet)
                {
                    MessageBox.Show("Số Tiết không Được Để Nhiều Khoảng Trắng");
                    textBoxSoTiet.Focus();
                }
                else if (!SoTietisNumBer)
                {
                    MessageBox.Show("Số Tiết Phải Là 1 Số Nguyên");
                    textBoxSoTiet.Focus();
                }
                else if (matchTiet)
                {
                    MessageBox.Show("Tiết không Được Để Nhiều Khoảng Trắng");
                    textBoxTiet.Focus();
                }
                else if (matchThu)
                {
                    MessageBox.Show("Thứ không Được Để Nhiều Khoảng Trắng");
                    textBoxThu.Focus();
                }
                else if (textBoxThu.Text.Length > 10)
                {
                    MessageBox.Show("Ô Thứ Tối Đa 10 Kí Tự ");
                    textBoxThu.Focus();
                }
                else if (textBoxTiet.Text.Length > 10)
                {
                    MessageBox.Show("Ô Thứ Tối Đa 10 Kí Tự ");
                    textBoxTiet.Focus();
                }
                else if (textBoxDiaDiem.Text.Length > 50)
                {
                    MessageBox.Show("Địa Điểm Tối Đa 50 Kí Tự ");
                    textBoxDiaDiem.Focus();
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Phân Công Nhiệm Vụ Giảng Dạy Này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            textBoxDiaDiem.Text = XoaKiTuTrangOGiua(textBoxDiaDiem.Text);
                            textBoxThu.Text = XoaKiTuTrangOGiua(textBoxThu.Text);
                            textBoxTiet.Text = XoaKiTuTrangOGiua(textBoxTiet.Text);
                            textBoxSoTiet.Text = XoaKiTuTrangOGiua(textBoxSoTiet.Text);
                            GiangDayBUS.InsertGiangday(comboBoxGiaoVien.SelectedValue.ToString(), comboBoxLop.Text, int.Parse(textBoxSoTiet.Text), textBoxDiaDiem.Text, textBoxThu.Text, textBoxTiet.Text);

                            MessageBox.Show("------Thành Công!!-------");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Lịch giảng dạy cho giáo viên tại lớp này đã tồn tại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lần Sau Cân Nhắc Kĩ Nha Bạn!!");
                    }
                }
            }
        }


        #endregion

        
    }
}

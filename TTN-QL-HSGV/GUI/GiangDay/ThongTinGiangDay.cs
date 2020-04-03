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
using System.Text.RegularExpressions;
using TTN_QL_HSGV.BUS;
using System.Diagnostics;

namespace TTN_QL_HSGV.GUI.GiangDay
{
    public partial class ThongTinGiangDay : Form
    {
        
        public ThongTinGiangDay()
        {
            InitializeComponent();
            
            comboBoxGiaoVien.DataSource = GiangDayBUS.GetDanhSachGiaoVienCaTruong();
            comboBoxLop.DataSource = GiangDayBUS.GetDanhSachLop();

        }
        public string maGVTam;
        public string maLopTam;


        public ThongTinGiangDay(string maGV, string maLop, int soTiet, string diaDiem, string thu, string tiet)
        {
            InitializeComponent();
            DataProvider.Instance.ToString();
            comboBoxGiaoVien.Text = maGV;
            comboBoxLop.Text = maLop;
            textBoxSoTiet.Text = soTiet.ToString();
            textBoxDiaDiem.Text = diaDiem;
            textBoxThu.Text = thu;
            textBoxTiet.Text = tiet;
            comboBoxGiaoVien.Enabled = true;
            textBoxDiaDiem.Enabled = true;
            textBoxMon.Text = DataProvider.Instance.ExecuteScalar("gettenmonhoc '" + maGV + "'").ToString();
            
            maGVTam = maGV;
            maLopTam = maLop;
        }
        #region Method

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


        #endregion



        #region Event

        private void buttonChiTietGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinGiaoVien formTTGV = new ThongTinGiaoVien(comboBoxGiaoVien.Text);
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
            ThongTinLop formTTL = new ThongTinLop(comboBoxLop.Text);
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
                    if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thay Đổi Phân Công Nhiệm Vụ Giảng Dạy Này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            textBoxDiaDiem.Text = XoaKiTuTrangOGiua(textBoxDiaDiem.Text);
                            textBoxThu.Text = XoaKiTuTrangOGiua(textBoxThu.Text);
                            textBoxTiet.Text = XoaKiTuTrangOGiua(textBoxTiet.Text);
                            textBoxSoTiet.Text = XoaKiTuTrangOGiua(textBoxSoTiet.Text);
                            
                            if (comboBoxGiaoVien.Text == maGVTam && comboBoxLop.Text != maLopTam)
                            {
                                GiangDayBUS.UpdateGiangDay(comboBoxGiaoVien.Text, comboBoxGiaoVien.Text, maLopTam, comboBoxLop.Text, int.Parse(textBoxSoTiet.Text), textBoxDiaDiem.Text, textBoxThu.Text, textBoxTiet.Text);                            
                            }
                            else if(comboBoxGiaoVien.Text != maGVTam && comboBoxLop.Text == maLopTam)
                            {
                                GiangDayBUS.UpdateGiangDay(maGVTam , comboBoxGiaoVien.Text, comboBoxLop.Text, comboBoxLop.Text, int.Parse(textBoxSoTiet.Text), textBoxDiaDiem.Text, textBoxThu.Text, textBoxTiet.Text);
                            }
                            else
                            {
                                GiangDayBUS.UpdateGiangDay(comboBoxGiaoVien.Text, comboBoxGiaoVien.Text, comboBoxLop.Text, comboBoxLop.Text, int.Parse(textBoxSoTiet.Text), textBoxDiaDiem.Text, textBoxThu.Text, textBoxTiet.Text);
                            }

                            MessageBox.Show("------Thành Công!!-------");
                            this.Close();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Xảy 1 lỗi gì đó chờ bản nâng cấp sau fix!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lần Sau Cân Nhắc Kĩ Nha Bạn!!");
                    }
                }
            }
        }

        private void comboBoxGiaoVien_Click(object sender, EventArgs e)
        {
            comboBoxGiaoVien.DataSource = GiangDayBUS.GetDanhSachGiaoVienCaTruong();
        }

        private void comboBoxLop_Click(object sender, EventArgs e)
        {
            comboBoxLop.DataSource = GiangDayBUS.GetDanhSachLop();
        }

        private void comboBoxGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGiaoVien.SelectedIndex > -1)
            {
                Trace.WriteLine("hihi");
                textBoxMon.Text = DataProvider.Instance.ExecuteScalar("gettenmonhoc '" + comboBoxGiaoVien.Text + "'").ToString();
            }
        }

        #endregion


    }
}

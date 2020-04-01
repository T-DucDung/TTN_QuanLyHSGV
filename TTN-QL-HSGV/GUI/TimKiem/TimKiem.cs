using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.GUI.TimKiem
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        //ghi thông tin vào 1 ô bên trên các ô còn lại có thể có hoặc không
        //nút chi tiết chỉ mở khi có 1 dòng đc chọn trong datagrv
        //set mặc định lúc mở của cái giới tính là None nhá

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            // truyền mã sang form bên kia
            this.Hide();
            ChiTiet formCT = new ChiTiet("");
            formCT.FormClosed += FormCT_FormClosed;
            formCT.Show();
        }

        private void FormCT_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            dataGridViewDS_HS.DataSource = BUS.TimKiem.TimKiemKoThongTin();
            textBoxTongSo.Text = dataGridViewDS_HS.RowCount.ToString();
            comboBoxGioiTinh.SelectedIndex = 2;
        }
        
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string HoTen;
            if (textBoxTen.Text != "")
                HoTen = textBoxTen.Text;
            else
                HoTen = "";

            string GioiTinh = comboBoxGioiTinh.SelectedItem.ToString();
            //string Lop = textBoxLop.Text;
            string Lop = "";
            //string KhoaHoc = textBoxKhoa.Text;
            string KhoaHoc = "";
            if (HoTen == "" && GioiTinh == "Không" && Lop == "" && KhoaHoc == "")
            {
                dataGridViewDS_HS.DataSource = BUS.TimKiem.TimKiemKoThongTin();
                textBoxTongSo.Text = dataGridViewDS_HS.RowCount.ToString();
            }    
            else if (textBoxLop.Text == "")
            {
                dataGridViewDS_HS.DataSource = BUS.TimKiem.TimKiemThongTinKoDungLop(HoTen, GioiTinh);
                textBoxTongSo.Text = dataGridViewDS_HS.RowCount.ToString();
            }   
            else if (textBoxLop.Text != "")
            {
                dataGridViewDS_HS.DataSource = BUS.TimKiem.TimKiemThongTinDungLop(HoTen, GioiTinh,Lop,KhoaHoc);
                textBoxTongSo.Text = dataGridViewDS_HS.RowCount.ToString();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.GUI.GiangDay;

namespace TTN_QL_HSGV.GUI.TimKiem
{
    public partial class ChiTiet : Form
    {
        private string ID;
        private string ChucVu1;
        public ChiTiet(string MaTimKiem,string ChucVu)
        {
            ID = MaTimKiem;
            ChucVu1 = ChucVu;
            InitializeComponent();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinGiangDay formTTGD = new ThongTinGiangDay();
            formTTGD.FormClosed += FormTTGD_FormClosed;
            formTTGD.Show();
        }

        private void FormTTGD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void ChiTiet_Load(object sender, EventArgs e)
        {
            comboBoxThu.SelectedIndex = 0;
            comboBoxBuoi.SelectedIndex = 0;
            comboBoxLop.SelectedIndex = 0;
            comboBoxGiaoVien.SelectedIndex = 0;
            if(ChucVu1 == "Giáo Viên")
            {
                dataGridViewDS_HS.DataSource = BUS.ChiTietBUS.XemLichGiaoVien(ID);
                textBoxTongSo.Text = (dataGridViewDS_HS.RowCount - 1).ToString();
            }    
            else
            {
                dataGridViewDS_HS.DataSource = BUS.ChiTietBUS.XemLichHocSinh(ID);
                textBoxTongSo.Text = (dataGridViewDS_HS.RowCount - 1).ToString();
            }
            foreach(DataGridViewRow dr in dataGridViewDS_HS.Rows)
            {
                

                if(dr.Cells[0].Value != null && ChucVu1 != "Giáo Viên")
                {
                    comboBoxGiaoVien.Items.Add(dr.Cells[0].Value.ToString());
                }    
                if(dr.Cells[1].Value != null)
                {
                    comboBoxLop.Items.Add(dr.Cells[1].Value.ToString());
                }    
                
            }
            if (ChucVu1 == "Giáo Viên")
            {
                comboBoxGiaoVien.Items.Add(ID);
            }
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            string Thu = comboBoxThu.SelectedItem.ToString();
            string Buoi = comboBoxBuoi.SelectedItem.ToString();
            string MaLop = comboBoxLop.SelectedItem.ToString();
            string MaGV = comboBoxGiaoVien.SelectedItem.ToString();
            if(ChucVu1 == "Học Sinh")
            {
                dataGridViewDS_HS.DataSource = BUS.ChiTietBUS.LocThongTinHocSinh(Thu,Buoi,MaLop,MaGV,ID);
                textBoxTongSo.Text = (dataGridViewDS_HS.RowCount - 1).ToString();
            }  
            else if (ChucVu1 == "Giáo Viên")
            {
                dataGridViewDS_HS.DataSource = BUS.ChiTietBUS.LocThongTinGiaoVien(Thu, Buoi, MaLop, ID);
                textBoxTongSo.Text = (dataGridViewDS_HS.RowCount - 1).ToString();
            }    
        }
    }
}

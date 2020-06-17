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
            DataGridViewRow current = dataGridViewDS_HS.CurrentRow;
            this.Hide();
            ThongTinGiangDay formTTGD = new ThongTinGiangDay(
                current.Cells[0].Value.ToString(),
                current.Cells[1].Value.ToString(),
                Convert.ToInt32(current.Cells[2].Value),
                current.Cells[3].Value.ToString(),
                current.Cells[4].Value.ToString(),
                current.Cells[5].Value.ToString());
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
                textBoxTongSo.Text = (dataGridViewDS_HS.Rows.Count).ToString();
            }    
            else
            {
                dataGridViewDS_HS.DataSource = BUS.ChiTietBUS.XemLichHocSinh(ID);
                textBoxTongSo.Text = (dataGridViewDS_HS.Rows.Count).ToString();
            }
            List<string> listGiaoVien = new List<string>();
            List<string> listLop = new List<string>();
            foreach(DataGridViewRow dr in dataGridViewDS_HS.Rows)
            {
                

                if(dr.Cells[0].Value != null && ChucVu1 != "Giáo Viên")
                {
                    listGiaoVien.Add(dr.Cells[0].Value.ToString());
                }    
                if(dr.Cells[1].Value != null)
                {
                    listLop.Add(dr.Cells[1].Value.ToString());
                }    
                
            }
            List<string> list = new List<string>();
            
            comboBoxLop.DataSource = listLop.Distinct().ToList();
            
            
            if (ChucVu1 == "Giáo Viên")
            {
                comboBoxGiaoVien.Items.Add(ID);
            }
            else
            {
                comboBoxGiaoVien.DataSource = listGiaoVien.Distinct().ToList();
            }    
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            string Thu = comboBoxThu.Text.ToString();
            string Buoi = comboBoxBuoi.Text.ToString();
            string MaLop = comboBoxLop.Text.ToString();
            string MaGV = comboBoxGiaoVien.Text.ToString();
            if(ChucVu1 == "Học Sinh")
            {
                dataGridViewDS_HS.DataSource = null;
                dataGridViewDS_HS.DataSource = BUS.ChiTietBUS.LocThongTinHocSinh(Thu,Buoi,MaLop,MaGV,ID);
                textBoxTongSo.Text = (dataGridViewDS_HS.Rows.Count).ToString();
            }  
            else if (ChucVu1 == "Giáo Viên")
            {
                dataGridViewDS_HS.DataSource = null;
                dataGridViewDS_HS.DataSource = BUS.ChiTietBUS.LocThongTinGiaoVien(Thu, Buoi, MaLop, ID);
                textBoxTongSo.Text = (dataGridViewDS_HS.Rows.Count).ToString();
            }    
        }

        private void dataGridViewDS_HS_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridViewDS_HS.Columns["MaGV"].HeaderText = "Mã GV";
            dataGridViewDS_HS.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridViewDS_HS.Columns["SoTiet"].HeaderText = "Số Tiết";
            dataGridViewDS_HS.Columns["DiaDiem"].HeaderText = "Địa Điểm";
            dataGridViewDS_HS.Columns["Thu"].HeaderText = "Thứ";
            dataGridViewDS_HS.Columns["Tiet"].HeaderText = "Tiết";
        }
    }
}

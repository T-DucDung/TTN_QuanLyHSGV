using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.BUS;
using TTN_QL_HSGV.DAL;


namespace TTN_QL_HSGV.GUI.GiangDay
{
    public partial class DanhSachGiangDay : Form
    {
        public DanhSachGiangDay()
        {
            InitializeComponent();
            dataGridViewDS_HS.DataSource = GiangDayBUS.LoadGiangDay();
            comboBoxLop.DataSource = GiangDayBUS.GetDanhSachLop2();
            comboBoxGiaoVien.DataSource = GiangDayBUS.GetDanhSachGiaoVien();
            textBoxTongSo.Text = DataProvider.Instance.ExecuteScalar("select count(*) tongso from GIANGDAY").ToString();

        }

        // khi lấy list danh sách đưa lên 2 combobox thì thêm 1 tùy chọn là "thêm mới"
        // nếu ấn chọn cái đấy thì link tới 2 form đó là thêm gv mới và thêm lớp mới


        #region MyMethod
       


        #endregion


        #region MyHandleEvent

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            // chọn 1 row rồi mới cho kích hoạt cái này
            this.Hide();
            DataGridViewRow current = dataGridViewDS_HS.CurrentRow;

            ThongTinGiangDay formTTGD = new ThongTinGiangDay(
                current.Cells[0].Value.ToString(),
                current.Cells[1].Value.ToString(),
                Convert.ToInt32(current.Cells[2].Value),
                current.Cells[3].Value.ToString(),
                current.Cells[4].Value.ToString(),
                current.Cells[5].Value.ToString()
                );
            formTTGD.FormClosed += FormTTGD_FormClosed;
            formTTGD.Show();
        }

        private void FormTTGD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            dataGridViewDS_HS.DataSource = GiangDayBUS.LoadGiangDay();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemGiangDay formTMGD = new ThemGiangDay();
            formTMGD.FormClosed += FormTMGD_FormClosed;
            formTMGD.Show();
            
        }

        private void FormTMGD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            dataGridViewDS_HS.DataSource = GiangDayBUS.LoadGiangDay();
            
        }

        private void dataGridViewDS_HS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            buttonChiTiet.Enabled = true;

        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {

            dataGridViewDS_HS.DataSource = GiangDayBUS.Filter(comboBoxGiaoVien.Text ,comboBoxLop.Text ,comboBoxThu.Text ,comboBoxBuoi.Text);
            textBoxTongSo.Text = (dataGridViewDS_HS.Rows.Count-1).ToString();
        }


        #endregion


    }
}

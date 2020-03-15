using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.GUI.GiangDay
{
    public partial class DanhSachGiangDay : Form
    {
        public DanhSachGiangDay()
        {
            InitializeComponent();
        }

        // khi lấy list danh sách đưa lên 2 combobox thì thêm 1 tùy chọn là "thêm mới"
        // nếu ấn chọn cái đấy thì link tới 2 form đó là thêm gv mới và thêm lớp mới

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            // chọn 1 row rồi mới cho kích hoạt cái này 
            this.Hide();
            ThongTinGiangDay formTTGD = new ThongTinGiangDay("","");
            formTTGD.FormClosed += FormTTGD_FormClosed;
            formTTGD.Show();
        }

        private void FormTTGD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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
        }
    }
}

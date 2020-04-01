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
        public ChiTiet(string MaTimKiem)
        {
            ID = MaTimKiem;

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
    }
}

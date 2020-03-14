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
using TTN_QL_HSGV.GUI.HocSinh;
using TTN_QL_HSGV.GUI.Lop;

namespace TTN_QL_HSGV
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }

        private void buttonGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachGiaoVien formDSGV = new DanhSachGiaoVien();
            formDSGV.FormClosed += FormDSGV_FormClosed;
            formDSGV.Show();
        }

        private void FormDSGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachHocSinh formDSHS = new DanhSachHocSinh();
            formDSHS.FormClosed += FormDSHS_FormClosed;
            formDSHS.Show();
        }

        private void FormDSHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonLich_Click(object sender, EventArgs e)
        {

        }

        private void buttonLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachLop formDSL = new DanhSachLop();
            formDSL.FormClosed += FormDSL_FormClosed;
            formDSL.Show();
        }

        private void FormDSL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}

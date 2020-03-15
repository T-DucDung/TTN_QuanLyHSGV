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


namespace TTN_QL_HSGV.GUI.GiangDay
{
    public partial class ThemGiangDay : Form
    {
        public ThemGiangDay()
        {
            InitializeComponent();
        }

        // khi lấy list danh sách đưa lên 2 combobox thì thêm 1 tùy chọn là "thêm mới"
        // nếu ấn chọn cái đấy thì link tới 2 form đó là thêm gv mới và thêm lớp mới

        private void buttonChiTietGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinGiaoVien formTTGV = new ThongTinGiaoVien("1");
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
            ThongTinLop formTTL = new ThongTinLop("1");
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
    }
}

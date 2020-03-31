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

namespace TTN_QL_HSGV.GUI.GiaoVien
{
    public partial class DanhSachGiaoVien : Form
    {
        public DanhSachGiaoVien()
        {
            InitializeComponent();

        }
        // phần lọc lấy danh sách từ database ra add dưới dạng list<A> thêm 'None' vào 
        // để mặc định hiển thị 'None' khi chọn mục này thì bỏ qua đk lọc

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //lấy id bằng cách chọn 1 dòng trong datagrv xong truyền qua form bên kia
            //nút chi tiết cần chỉ bật khi đang chọn 1 dòng trong datagrv nếu không chọn dòng nào thì để tắt
            this.Hide();
            ThongTinGiaoVien formTTGV = new ThongTinGiaoVien("1");
            formTTGV.FormClosed += FormTTGV_FormClosed;
            formTTGV.Show();
        }

        private void FormTTGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemGiaoVien formTMGV = new ThemGiaoVien();
            formTMGV.FormClosed += FormTMGV_FormClosed;
            formTMGV.Show();
        }

        private void FormTMGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

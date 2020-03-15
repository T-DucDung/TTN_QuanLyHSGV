using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.GUI.HocSinh;

namespace TTN_QL_HSGV.GUI.Lop
{
    public partial class ThemHocSinhVaoLop : Form
    {
        private string MaLop;
        public ThemHocSinhVaoLop(string Ma)
        {
            //lấy mã lớp sang đây để sửa mã lớp cho học sinh sau khi chọn 
            MaLop = Ma;

            InitializeComponent();
        }

        // phần lọc lấy danh sách từ database ra add dưới dạng list<A> thêm 'None' vào 
        // để mặc định hiển thị 'None' khi chọn mục này thì bỏ qua đk lọc

        // datagrv ở form này yêu cầu ghép thêm checkbox để tích chọn học sinh 

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //lấy id bằng cách chọn 1 dòng trong datagrv xong truyền qua form bên kia
            //nút chi tiết cần chỉ bật khi đang chọn 1 dòng trong datagrv nếu không chọn dòng nào thì để tắt
            ThongTinHocSinh formTTHS = new ThongTinHocSinh("1");
            formTTHS.Show();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHocSinh formTMHS = new ThemHocSinh();
            formTMHS.FormClosed += FormTMHS_FormClosed;
            formTMHS.Show();
        }

        private void FormTMHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

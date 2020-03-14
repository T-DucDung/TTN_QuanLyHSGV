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
    public partial class ThongTinLop : Form
    {
        private int ID;
        public ThongTinLop(int IDLop)
        {
            ID = IDLop;

            InitializeComponent();
        }
        // Phần lọc 2 textbox đằng sau chỉ hiển thị tên lớp với khóa học 
        // lấy danh sách từ database ra add dưới dạng list<A> thêm 'None' vào 
        // để mặc định hiển thị 'None' khi chọn mục này thì bỏ qua đk lọc

        // ấn chi tiết để xem giáo viên đang được chọn trong combobox
        // giáo viên chủ nhiệm lớp sẽ được set mặc định hiển thị của combobox, môn học tự render khi chọn gv
        // có thể chọn giáp viên khác làm gvcn
        // xử lý sự kiện đóng form kiểm tra giáo viên được chọn trong combobox là gvcn mới hay cũ 
        // nếu là mới thì đưa ra dialog xác nhận thay đổi gvcn

        // xử lý xóa lớp đưa toàn bộ học sinh trong danh sáchvề null ở trường malop

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            //Truyền mã lớp qua đây, muốn biết chi tiết thì qua form thêm học sinh bên dưới 
            ThemHocSinh formTMHS = new ThemHocSinh(1);
            formTMHS.FormClosed += FormTMHS_FormClosed;
            formTMHS.Show();
        }

        private void FormTMHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //Truyền mã hs qua đây để xem chi tiết 
            //yêu cầu nút chi tiết chỉ bật khi có 1 dòng được chọn trên datagrv
            ThongTinHocSinh formTTHS = new ThongTinHocSinh(1);
            formTTHS.Show();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using TTN_QL_HSGV.GUI.GiaoVien;
using TTN_QL_HSGV.BUS;

namespace TTN_QL_HSGV.GUI.Lop
{
    public partial class ThongTinLop : Form
    {
        private string ID;
        private LopBUS bus;

        HocSinhBUS controllerHS = new HocSinhBUS();

        public ThongTinLop(string IDLop)
        {
            ID = IDLop;
            bus = new LopBUS();
            InitializeComponent();
            dataGridViewDS_HS.DataSource = controllerHS.XemTatCaHSLop(IDLop);

        }
        // Phần lọc 2 textbox đằng sau chỉ hiển thị tên lớp với khóa học 
        // lấy danh sách từ database ra add dưới dạng list<A> thêm 'None' vào 
        // để mặc định hiển thị 'None' khi chọn mục này thì bỏ qua đk lọc
        // phần combobox giáo viên và khóa học thêm phần 'thêm mới'
        // khi click vào đó thì ra form thêm mới gv và thêm mới khóa học 
        // khóa học ở form phụ

        // ấn chi tiết để xem giáo viên đang được chọn trong combobox
        // giáo viên chủ nhiệm lớp sẽ được set mặc định hiển thị của combobox, môn học tự render khi chọn gv
        // có thể chọn giáp viên khác làm gvcn tuong tự cho tên lớp với khóa học

        // xử lý sự kiện đóng form kiểm tra giáo viên được chọn trong combobox là gvcn mới hay cũ 
        // nếu là mới thì đưa ra dialog xác nhận thay đổi gvcn
        // tương tự kiểm tra sự thay đổi của tên lớp và khóa học của lớp

        // xử lý xóa lớp đưa toàn bộ học sinh trong danh sách về null ở trường malop


        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Truyền mã lớp qua đây, muốn biết chi tiết thì qua form bên dưới 
            ThemHocSinhVaoLop formTMHS = new ThemHocSinhVaoLop("1");
            formTMHS.FormClosed += FormTMHS_FormClosed;
            formTMHS.Show();
        }

        private void FormTMHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //Truyền mã hs qua đây để xem chi tiết 
            //yêu cầu nút chi tiết chỉ bật khi có 1 dòng được chọn trên datagrv
            this.Hide();
            ThongTinHocSinh formTTHS = new ThongTinHocSinh("1");
            formTTHS.FormClosed += FormTTHS_FormClosed;
            formTTHS.Show();
        }

        private void FormTTHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void ThongTinLop_Load(object sender, EventArgs e)
        {
            comboBoxKhoaHoc.DataSource = bus.GetDanhSachKhoaHoc();
        }
    }
}

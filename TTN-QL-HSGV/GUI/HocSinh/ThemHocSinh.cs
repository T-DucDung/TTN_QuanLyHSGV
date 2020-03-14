using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.GUI.HocSinh
{
    public partial class ThemHocSinh : Form
    {
        public ThemHocSinh()
        {
            InitializeComponent();
        }

        // hàm này để gọi lại form này bên form lớp khi ấn nút thêm học sinh
        // nếu hàm khởi tạo này được gọi thì lock ô mã lớp vào không cho chọn nữa
        // lớp sẽ mặc định là lớp được truyền vào 
        public ThemHocSinh(int MaLop)
        {
            InitializeComponent();
        }

        // lấy thông tin lên form riêng phần lớp thì truy xuất danh sách mã sang tên để chọn 
        // sử dụng các hàm viết trong BUS
        // thiếu thì viết thêm tuyệt đối không được sửa trong DAL
        // combox lấy data từ base lên add vào list rồi chọn datasource là list đó
        // thêm vào list vị trí cuối cùng là 'thêm mới' rồi xử lý chọn dòng đấy để gọi 1 form mới tương ứng

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

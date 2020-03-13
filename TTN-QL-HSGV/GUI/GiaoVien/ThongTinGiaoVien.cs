using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.GUI.GiaoVien
{
    public partial class ThongTinGiaoVien : Form
    {
        //ID sử dụng truy xuất và sửa thông tin
        private int ID;
        public ThongTinGiaoVien(int IDGiaoVien)
        {
            ID = IDGiaoVien;

            InitializeComponent();
        }
        // lấy thông tin lên form riêng phần môn thì truy xuất danh sách mã sang tên để chọn 
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

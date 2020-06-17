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
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.GUI.Lop
{
    public partial class ThongTinLop : Form
    {
        private string ID;
        private LopBUS Lbus;
        private HocSinhBUS HSbus;
        private GiaoVienBUS GVbus;
        private List<DTO.HocSinh> hocSinhs;
        public ThongTinLop(string IDLop)
        {
            ID = IDLop;
            InitializeComponent();
            Lbus = new LopBUS();
            HSbus = new HocSinhBUS();
            GVbus = new GiaoVienBUS();
            hocSinhs = new List<DTO.HocSinh>();
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
            ThemHocSinhVaoLop formTMHS = new ThemHocSinhVaoLop(ID);
            formTMHS.FormClosed += FormTMHS_FormClosed;
            formTMHS.Show();
        }

        private void FormTMHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            hocSinhs = HSbus.XemTatCaHSLop(this.ID);
            dataGridViewDS_HS.DataSource = null;
            dataGridViewDS_HS.DataSource = hocSinhs;
            ReName();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //Truyền mã hs qua đây để xem chi tiết 
            //yêu cầu nút chi tiết chỉ bật khi có 1 dòng được chọn trên datagrv
            try
            {
                this.Hide();
                ThongTinHocSinh formTTHS = new ThongTinHocSinh(dataGridViewDS_HS.CurrentRow.Cells[0].Value.ToString());
                formTTHS.FormClosed += FormTTHS_FormClosed;
                formTTHS.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Học sinh được chọn không khả dụng");
            }
        }

        private void FormTTHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            hocSinhs = HSbus.XemTatCaHSLop(this.ID);
            dataGridViewDS_HS.DataSource = null;
            dataGridViewDS_HS.DataSource = hocSinhs;
            ReName();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTietGV_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                string[] info = comboBoxGVCN.Text.Split(':');
                string maGV = info[0];
                ThongTinGiaoVien formTTGV = new ThongTinGiaoVien(maGV);
                formTTGV.FormClosed += FormTTGV_FormClosed;
                formTTGV.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Giáo viên được chọn không khả dụng");
            }
        }

        private void FormTTGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            comboBoxGVCN.DataSource = null;
            comboBoxGVCN.DataSource = GVbus.XemDanhSachTenGV();
        }

        private void ThongTinLop_Load(object sender, EventArgs e)
        {
            comboBoxKhoaHoc.DataSource = Lbus.GetDanhSachKhoaHoc();
            hocSinhs = HSbus.XemTatCaHSLop(this.ID);
            dataGridViewDS_HS.DataSource = hocSinhs;
            ReName();
            comboBoxGVCN.DataSource = GVbus.XemDanhSachTenGV();
            textBoxLop.Text = Lbus.GetTenLop(ID);
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string[] info = comboBoxGVCN.Text.Split(':');
                string maGV = info[0];
                Lbus.UpdateLop(ID, textBoxLop.Text, maGV, comboBoxKhoaHoc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu thông tin, vui lòng thử lại");
            }
        }

        private void dataGridViewDS_HS_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dataGridViewDS_HS.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = getSortOrder(e.ColumnIndex);
            hocSinhs.Sort(new HocSinhComparer(strColumnName, strSortOrder));
            dataGridViewDS_HS.DataSource = null;
            dataGridViewDS_HS.DataSource = hocSinhs;
            ReName();
            dataGridViewDS_HS.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }
        private SortOrder getSortOrder(int columnIndex)
        {
            if (dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                 dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                return SortOrder.Ascending;
            }
            else
            {
                dataGridViewDS_HS.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                return SortOrder.Descending;
            }
        }
        private void ReName()
        {
            dataGridViewDS_HS.Columns["MaHS"].HeaderText = "Mã HS";
            dataGridViewDS_HS.Columns["TenHS"].HeaderText = "Tên HS";
            dataGridViewDS_HS.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridViewDS_HS.Columns["Sdt"].HeaderText = "SĐT";
            dataGridViewDS_HS.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridViewDS_HS.Columns["MaLop"].HeaderText = "Mã Lớp";
        }

    }
}

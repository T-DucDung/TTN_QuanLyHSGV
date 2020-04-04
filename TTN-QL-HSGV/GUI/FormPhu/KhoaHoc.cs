using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.BUS;

namespace TTN_QL_HSGV.GUI.Lop
{
    public partial class KhoaHoc : Form
    {
        public KhoaHoc()
        {
            InitializeComponent();
        }
        // click đúp dòng trong datagrv thì dữ liệu sẽ lên 2 textbox trên và cho sửa 
        // nếu không thì mặc định nút sửa sẽ tắt

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhoaHoc_Load(object sender, EventArgs e)
        {
            dataGridViewDS_KH.DataSource = KhoaHocBUS.SelectAllKhoaHoc();
            buttonSua.Enabled = false;
            textBoxTongSo.Text = (dataGridViewDS_KH.RowCount - 1).ToString();
        }

        private void dataGridViewDS_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow current = dataGridViewDS_KH.CurrentRow;
            textBoxMaKhoa.Text = current.Cells[0].Value.ToString();
            textBoxTenKH.Text = current.Cells[1].Value.ToString();
            buttonSua.Enabled = true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaKhoa.Text != "" && textBoxTenKH.Text != "")
            {
                if (KhoaHocBUS.KiemTraMa(textBoxMaKhoa.Text) == true)
                {
                    MessageBox.Show("Mã đã tồn tại \n Nhập mã mới \n Hoặc chọn sửa");
                }
                else
                {
                    KhoaHocBUS.ThemKH(textBoxMaKhoa.Text, textBoxTenKH.Text);
                    dataGridViewDS_KH.DataSource = KhoaHocBUS.SelectAllKhoaHoc();
                    textBoxTongSo.Text = (dataGridViewDS_KH.RowCount - 1).ToString();
                }    
            }
            else
                MessageBox.Show("Nhập đầy đủ mã khoá học và tên khoá học");
              
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridViewDS_KH.CurrentRow;
            KhoaHocBUS.SuaKH(current.Cells[0].Value.ToString(), textBoxTenKH.Text);
            dataGridViewDS_KH.DataSource = KhoaHocBUS.SelectAllKhoaHoc();
            textBoxTongSo.Text = (dataGridViewDS_KH.RowCount - 1).ToString();
        }
    }
}

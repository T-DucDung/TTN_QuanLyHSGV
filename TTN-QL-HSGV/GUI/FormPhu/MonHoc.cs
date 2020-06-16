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

namespace TTN_QL_HSGV.GUI.FormPhu
{
    public partial class MonHoc : Form
    {
        MonHocBUS monhocbus = new MonHocBUS();
        public MonHoc()
        {
            InitializeComponent();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            dataGridViewDS_MH.DataSource = monhocbus.XemTatCaMonHoc();
            textBoxTongSo.Text = (dataGridViewDS_MH.RowCount).ToString();
            dataGridViewDS_MH.Columns[0].HeaderText = "Mã MH";
            dataGridViewDS_MH.Columns[1].HeaderText = "Tên MH";
            dataGridViewDS_MH.Columns[2].HeaderText = "Mã Khoa";
        }

        private void dataGridViewDS_MH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow current = dataGridViewDS_MH.CurrentRow;
            textBoxMaMon.Text = current.Cells[0].Value.ToString();
            textBoxTenMon.Text = current.Cells[1].Value.ToString();
            if (current.Cells[2].Value.ToString() == "NANGKHIEU")
                comboMaKhoa.SelectedIndex = 0;
            if (current.Cells[2].Value.ToString() == "TUNHIEN")
                comboMaKhoa.SelectedIndex = 1;
            if (current.Cells[2].Value.ToString() == "XAHOI")
                comboMaKhoa.SelectedIndex = 2;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaMon.Text != null &&
                textBoxTenMon.Text != null)
            {
                if(monhocbus.KiemTraMaMonHoc(textBoxMaMon.Text) == true)
                {
                    MessageBox.Show("Mã môn đã tồn tại \n Nhập mã môn mới \n Hoặc chọn sửa");
                }    
                else
                {
                    monhocbus.ThemMonHoc(textBoxMaMon.Text, textBoxTenMon.Text, comboMaKhoa.SelectedItem.ToString());
                    dataGridViewDS_MH.DataSource = monhocbus.XemTatCaMonHoc();
                    textBoxTongSo.Text = (dataGridViewDS_MH.RowCount).ToString();
                }    
            }
            else
                MessageBox.Show("Nhập đầy đủ mã môn và mã môn");
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            monhocbus.SuaMonHoc(textBoxMaMon.Text, textBoxTenMon.Text, comboMaKhoa.SelectedItem.ToString());
            dataGridViewDS_MH.DataSource = monhocbus.XemTatCaMonHoc();
            textBoxTongSo.Text = (dataGridViewDS_MH.RowCount).ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxMaMon.Text = "";
            textBoxTenMon.Text = "";
        }
    }
}

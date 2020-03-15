using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

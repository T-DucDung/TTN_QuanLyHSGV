using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.GUI.TimKiem
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        //ghi thông tin vào 1 ô bên trên các ô còn lại có thể có hoặc không
        //nút chi tiết chỉ mở khi có 1 dòng đc chọn trong datagrv
        //set mặc định lúc mở của cái giới tính là None nhá

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

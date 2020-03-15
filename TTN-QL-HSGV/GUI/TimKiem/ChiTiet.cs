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
    public partial class ChiTiet : Form
    {
        private string ID;
        public ChiTiet(string MaTimKiem)
        {
            ID = MaTimKiem;

            InitializeComponent();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.GUI.GiaoVien;
using TTN_QL_HSGV.GUI.HocSinh;
using TTN_QL_HSGV.GUI.Lop;
using TTN_QL_HSGV.GUI.GiangDay;
using TTN_QL_HSGV.GUI.TimKiem;

namespace TTN_QL_HSGV
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }

        private void buttonGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachGiaoVien formDSGV = new DanhSachGiaoVien();
            formDSGV.FormClosed += FormDSGV_FormClosed;
            formDSGV.Show();
        }

        private void FormDSGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachHocSinh formDSHS = new DanhSachHocSinh();
            formDSHS.FormClosed += FormDSHS_FormClosed;
            formDSHS.Show();
        }

        private void FormDSHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonLich_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachGiangDay formDSGD = new DanhSachGiangDay();
            formDSGD.FormClosed += FormDSGD_FormClosed;
            formDSGD.Show();
        }

        private void FormDSGD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachLop formDSL = new DanhSachLop();
            formDSL.FormClosed += FormDSL_FormClosed;
            formDSL.Show();
        }

        private void FormDSL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimKiem formTK = new TimKiem();
            formTK.FormClosed += FormTK_FormClosed;
            formTK.Show();
        }

        private void FormTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

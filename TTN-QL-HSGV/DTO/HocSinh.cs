﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class HocSinh
    {
        private string maHS;
        private string tenHS;
        private string diaChi;
        private string gioiTinh;
        private string sdt;
        private string maLop;
        

        public HocSinh() { }
        public HocSinh(string maHS, string tenHS, string diaChi, string gioiTinh, string sdt, string maLop)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.maLop = maLop;
        }

        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaLop { get => maLop; set => maLop = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class HocSinh
    {
        private int MaHS;
        private string TenHS;
        private string DiaChi;
        private string GioiTinh;
        private string SDT;
        private int MaLop;

        public HocSinh(int maHS, string tenHS, string diaChi, string gioiTinh, string sDT, int maLop)
        {
            MaHS = maHS;
            TenHS = tenHS;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            SDT = sDT;
            MaLop = maLop;
        }

        public int MaHS1 { get => MaHS; set => MaHS = value; }
        public string TenHS1 { get => TenHS; set => TenHS = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public int MaLop1 { get => MaLop; set => MaLop = value; }
    }
}

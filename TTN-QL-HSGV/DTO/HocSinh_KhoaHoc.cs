using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class HocSinh_KhoaHoc : HocSinh
    {
        private string tenKH;
        private string maKH;

        public HocSinh_KhoaHoc(string maHS, string tenHS, string diaChi, string gioiTinh, string sdt, string maLop, string tenKH, string maKH) : base(maHS, tenHS, diaChi, gioiTinh, sdt, maLop)
        {
            TenKH = tenKH;
            MaKH = maKH;
        }

        public string TenKH { get => tenKH; set => tenKH = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}

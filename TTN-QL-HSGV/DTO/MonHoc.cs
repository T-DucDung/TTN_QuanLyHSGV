using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class MonHoc
    {
        private int MaMon;
        private string TenMon;
        private int MaKhoa;

        public MonHoc(int maMon, string tenMon, int maKhoa)
        {
            MaMon = maMon;
            TenMon = tenMon;
            MaKhoa = maKhoa;
        }

        public int MaMon1 { get => MaMon; set => MaMon = value; }
        public string TenMon1 { get => TenMon; set => TenMon = value; }
        public int MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
    }
}

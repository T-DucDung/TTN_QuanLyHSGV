using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class MonHoc
    {
        private int maMon;
        private string tenMon;
        private int maKhoa;

        public MonHoc(int maMon, string tenMon, int maKhoa)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
            this.maKhoa = maKhoa;
        }

        public int MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}

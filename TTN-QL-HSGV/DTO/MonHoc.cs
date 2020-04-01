using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class MonHoc
    {
        private string maMon;
        private string tenMon;
        private string maKhoa;

        public MonHoc(string maMon, string tenMon, string maKhoa)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
            this.maKhoa = maKhoa;
        }

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}

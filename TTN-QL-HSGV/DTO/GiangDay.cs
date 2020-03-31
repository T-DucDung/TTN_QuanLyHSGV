using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class GiangDay
    {
        private string maGV;
        private string maLop;
        private int soTiet;

        public GiangDay(string maGV, string maLop, int soTiet)
        {
            this.maGV = maGV;
            this.maLop = maLop;
            this.soTiet = soTiet;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public int SoTiet { get => soTiet; set => soTiet = value; }
    }
}

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
        private int maGV;
        private int maLop;
        private int soTiet;

        public GiangDay(int maGV, int maLop, int soTiet)
        {
            this.maGV = maGV;
            this.maLop = maLop;
            this.soTiet = soTiet;
        }

        public int MaGV { get => maGV; set => maGV = value; }
        public int MaLop { get => maLop; set => maLop = value; }
        public int SoTiet { get => soTiet; set => soTiet = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class Lop
    {
        private int maLop;
        private string tenLop;
        private int maGVCN;
        private int maKhoaHoc;

        public Lop(int maLop, string tenLop, int maGVCN, int maKhoaHoc)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maGVCN = maGVCN;
            this.maKhoaHoc = maKhoaHoc;
        }

        public int MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int MaGVCN { get => maGVCN; set => maGVCN = value; }
        public int MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
    }
}

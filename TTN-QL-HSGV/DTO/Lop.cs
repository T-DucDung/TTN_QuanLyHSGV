using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class Lop
    {
        private string maLop;
        private string tenLop;
        private string maGVCN;
        private string maKhoaHoc;

        public Lop()
        {
            this.maLop = "";
            this.tenLop = "";
            this.maGVCN = "";
            this.maKhoaHoc = "";
        }

        public Lop(string maLop, string tenLop, string maGVCN, string maKhoaHoc)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maGVCN = maGVCN;
            this.maKhoaHoc = maKhoaHoc;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaGVCN { get => maGVCN; set => maGVCN = value; }
        public string MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc = value; }
    }
}

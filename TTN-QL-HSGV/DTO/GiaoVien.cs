using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class GiaoVien
    {
        private int maGV;
        private string tenGV;
        private string diaChi;
        private string gioiTinh;
        private string sdt;
        private string chucVu;
        private int maMon;
        //private byte[] anhDaiDien;

        public GiaoVien()
        {

        }

        public GiaoVien(int maGV, string tenGV, string diaChi, string gioiTinh, string sdt, string chucVu, int maMon)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.chucVu = chucVu;
            this.maMon = maMon;
            //this.anhDaiDien = anhDaiDien;
        }

        public int MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int MaMon { get => maMon; set => maMon = value; }
        //public byte[] AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
    }
}

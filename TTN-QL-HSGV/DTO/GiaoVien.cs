using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class GiaoVien
    {
        private int MaGV;
        private string TenGV;
        private string DiaChi;
        private string GioiTinh;
        private string SDT;
        private string ChucVu;
        private string MaMon;

        public GiaoVien(int maGV, string tenGV, string diaChi, string gioiTinh, string sDT, string chucVu, string maMon)
        {
            MaGV = maGV;
            TenGV = tenGV;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            SDT = sDT;
            ChucVu = chucVu;
            MaMon = maMon;
        }

        public int MaGV1 { get => MaGV; set => MaGV = value; }
        public string TenGV1 { get => TenGV; set => TenGV = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public string MaMon1 { get => MaMon; set => MaMon = value; }
    }
}

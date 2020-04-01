using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    class HocSinh
    {
        private int maHS;
        private string tenHS;
        private string diaChi;
        private string gioiTinh;
        private string sdt;
        private int maLop;

        public HocSinh(int maHS, string tenHS, string diaChi, string gioiTinh, string sdt, int maLop)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.maLop = maLop;
        }

        public int MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int MaLop { get => maLop; set => maLop = value; }
    }
    
    class CheckHocSinh
    {
        private bool check;
        private string maHS;
        private string tenHS;
        private string diaChi;
        private string gioiTinh;
        private string sdt;
        private string maLop;

        public CheckHocSinh()
        {
            this.check = false;
            this.maHS = "";
            this.tenHS = "";
            this.diaChi = "";
            this.gioiTinh = "";
            this.sdt = "";
            this.maLop = "";
        }

        public CheckHocSinh(bool check,string maHS, string tenHS, string diaChi, string gioiTinh, string sdt, string maLop)
        {
            this.check = check;
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.maLop = maLop;
        }

        public bool Check { get => check; set => check = value; }
        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaLop { get => maLop; set => maLop = value; }
    }
}

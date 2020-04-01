using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DTO
{
    public class GiangDay
    {
        private string maGV;
        private string maLop;
        private int soTiet;
        private string diaDiem;
        private string thu;
        private string tiet;
       

       /* public GiangDay(string maGV, string maLop, int soTiet , string diaDiem , string thu , string tiet)
        {
            this.MaGV = maGV;
            this.MaLop = maLop;
            this.SoTiet = soTiet;
            this.DiaDiem = diaDiem;
            this.Thu = thu;
            this.Tiet = tiet;
        }*/


        public string MaGV { get => maGV; set => maGV = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public int SoTiet { get => soTiet; set => soTiet = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string Thu { get => thu; set => thu = value; }
        public string Tiet { get => tiet; set => tiet = value; }
    }
}

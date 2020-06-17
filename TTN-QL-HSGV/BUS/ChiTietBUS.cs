using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.BUS
{
    class ChiTietBUS
    {
        private static void XuLyDauVao(ref string Thu, ref string Buoi, ref string MaGV, ref string MaLop)
        {
            if (Thu == "Cả Tuần")
                Thu = "%";
            else
            {
                Thu = Thu.Replace("Thứ ", "");
                Thu = "%" + Thu + "%";
            }
            XuLyBuoi(ref Buoi);
            if (MaGV == "None")
                MaGV = "%";
            if (MaLop == "None")
                MaLop = "%";
        }

        private static void XuLyBuoi(ref string Buoi)
        {
            if (Buoi == "Cả sáng, chiều")
                Buoi = "and " +
                    "Tiet like '%' ";
            else if (Buoi == "Sáng")
            {
                Buoi = "" +
                    "and " +
                    "(Tiet like '%1%' " +
                    "or " +
                    "Tiet like '%2%' " +
                    "or " +
                    "Tiet like '%3%' " +
                    "or " +
                    "Tiet like '%4%' " +
                    "or " +
                    "Tiet like '%5%' " +
                    "or " +
                    "Tiet like '%6%') ";
            }
            else if (Buoi == "Chiều")
            {
                Buoi = "" +
                    "and " +
                    "(Tiet like '%7%' " +
                    "or " +
                    "Tiet like '%8%' " +
                    "or " +
                    "Tiet like '%9%' " +
                    "or " +
                    "Tiet like '%10%' " +
                    "or " +
                    "Tiet like '%11%' " +
                    "or " +
                    "Tiet like '%12%') ";
            }

        }
        public static DataTable XemLichGiaoVien(string MaGV)
        {
            DataTable result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaGV,MaLop,SoTiet,DiaDiem,Thu,Tiet " +
                "from GIANGDAY " +
                $"where MaGV = '{MaGV}'");
            return result;
        }
        public static DataTable XemLichHocSinh(string MaHS)
        {
            DataTable result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaGV,HOCSINH.MaLop,SoTiet,DiaDiem,Thu,Tiet " +
                "from GIANGDAY,HOCSINH " +
                $"where MaHS = '{MaHS}' " +
                "and " +
                "HOCSINH.MaLop = GIANGDAY.MaLop ");
            return result;
        }
        public static DataTable LocThongTinHocSinh(string Thu, string Buoi, string MaLop, string MaGV, string MaHS)
        {
            XuLyDauVao(ref Thu, ref Buoi, ref MaGV, ref MaLop);
            DataTable result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaGV,HOCSINH.MaLop,SoTiet,DiaDiem,Thu,Tiet " +
                "from GIANGDAY,HOCSINH " +
                $"where MaHS like '{MaHS}' " +
                "and " +
                "HOCSINH.MaLop = GIANGDAY.MaLop " +
                "and " +
                $"GIANGDAY.Thu like '{Thu}' " +
                "and " +
                $"GIANGDAY.MaGV like '{MaGV}' "
                + Buoi);
            return result;
        }
        public static DataTable LocThongTinGiaoVien(string Thu, string Buoi, string MaLop, string MaGV)
        {
            XuLyDauVao(ref Thu, ref Buoi, ref MaGV, ref MaLop);
            DataTable result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaGV,MaLop,SoTiet,DiaDiem,Thu,Tiet " +
                "from GIANGDAY " +
                $"where " +
                $"MaGV like '{MaGV}' " +
                "and " +
                $"MaLop like '{MaLop}' " +
                "and " +
                $"Thu like '{Thu}' "
                + Buoi);
            return result;
        }
    }
}

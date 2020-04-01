using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TTN_QL_HSGV.DAL;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.BUS
{
    class GiangDayBUS 
    {

        //DataProvider data = new DataProvider();

        public static DataTable LoadGiangDay()
        {
            return DataProvider.Instance.ExecuteQuery("XEMLICHGIANGDAY");
        }


        public List<GiangDay> ThemMoiGiangDay()
        {
            List<GiangDay> giangDays = new List<GiangDay>();


            return giangDays;

        }

        public static List<string> GetDanhSachLop()
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("SELECT MaLop FROM LOP");
           
            return Convert(dt);
        }


        public static List<string> GetDanhSachGiaoVien()
        {
            DataTable dt = new DataTable();
            
            dt = DataProvider.Instance.ExecuteQuery("SELECT DISTINCT MaGV From GIANGDAY");

            return Convert(dt);
        }


        public static List<string> GetDanhSachGiaoVienCaTruong()
        {
            DataTable dt = new DataTable();

            dt = DataProvider.Instance.ExecuteQuery("SELECT MaGV From GIAOVIEN");

            return Convert(dt);
        }


        public static List<string> Convert(DataTable dt)
        {
            List<string> List = new List<string>() { "Tất cả" };

            foreach (DataRow dr in dt.Rows)
            {
                List.Add(dr[0].ToString());
            }

           /* foreach (var item in List)
            {
                Trace.WriteLine(item);
            }*/
            return List;
        }

        public static void InsertGiangday(string maGV , string maLop , int soTiet , string diaDiem , string thu , string tiet)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERTGIANGDAY '" +maGV +"','" +maLop +"','" +soTiet+"','"+diaDiem+"','"+thu+"','"+tiet+"'");
        }

        public static void UpdateGiangDay(string maGV1, string maGV2, string maLop1, string maLop2, int soTiet, string diaDiem, string thu, string tiet)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATEGIANGDAY '" + maGV1 + "','" + maGV2 +"','" + maLop1 + "','" + maLop2 + "','" + soTiet + "','" + diaDiem + "','" + thu + "','" + tiet + "'");
        }

        public static DataTable Filter(string maGV, string maLop, string thu, string tiet)
        {
            Trace.WriteLine(maGV);
            Trace.WriteLine(maLop);
            Trace.WriteLine(thu);
            Trace.WriteLine(tiet);
            return DataProvider.Instance.ExecuteQuery("FilterInfo '"+maGV+"','"+maLop+"','"+thu+"','"+tiet+"'");
        }

        
    }

}

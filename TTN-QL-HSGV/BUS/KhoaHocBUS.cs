using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.BUS
{
    class KhoaHocBUS
    {
        public static DataTable SelectAllKhoaHoc()
        {
            DataTable Result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select * " +
                "from KhoaHoc ");
            return Result;
        }
        public static bool KiemTraMa(string MaKH)
        {
            bool s;
            if (DAL.DataProvider.Instance.ExecuteScalar($"select * from KHOAHOC where MaKH = '{MaKH}'") != null)
            {
                s = true;
            }
            else
                s = false;
            return s;
        }
        public static void ThemKH(string MaKH,string TenKH)
        {
            DAL.DataProvider.Instance.ExecuteNonQuery("insert into KHOAHOC(MaKH,TenKH) " +
                $"values('{MaKH}',N'{TenKH}'");
        }
        public static void SuaKH(string MaKH,string TenKH)
        {
            DAL.DataProvider.Instance.ExecuteNonQuery("update KHOAHOC " +
                $"set TenKH = N'{TenKH}' where MaKH = '{MaKH}'");
        }
    }
}

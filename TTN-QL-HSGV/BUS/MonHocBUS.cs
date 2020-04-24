using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QL_HSGV.DTO;
using TTN_QL_HSGV.DAL;
using System.Data;

namespace TTN_QL_HSGV.BUS
{
    class MonHocBUS
    {
        public List<MonHoc> XemTatCaMonHoc()
        {
            return DataProvider.Instance.ExecuteQuery("select * from MONHOC").AsEnumerable().Select(m =>
            new MonHoc(m.Field<string>("MaMon"), m.Field<string>("TenMon"), m.Field<string>("MaKhoa"))).ToList();
        }
        public void ThemMonHoc(string MaMon,string TenMon,string MaKhoa)
        {
            DataProvider.Instance.ExecuteQuery("insert into MONHOC(MaMon,TenMon,MaKhoa)" +
                $"values('{MaMon}',N'{TenMon}','{MaKhoa}')");
        }
        public void SuaMonHoc(string MaMon,string TenMon,string MaKhoa)
        {
            DataProvider.Instance.ExecuteQuery("update MONHOC " +
                $"set TenMon = N'{TenMon}', MaKhoa = '{MaKhoa}' where MaMon = '{MaMon}'");
        }
        public bool KiemTraMaMonHoc(string MaMon)
        {
            bool s;
            if (DataProvider.Instance.ExecuteScalar($"select * from MONHOC where MaMon = '{MaMon}'") != null)
            {
                s = true;
            }
            else
                s = false;
            return s;
        }
    }
}

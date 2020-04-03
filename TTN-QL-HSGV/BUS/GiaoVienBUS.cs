using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.DAL;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.BUS
{
    class GiaoVienBUS
    {
        public bool ThemGV(GiaoVien giaoVien)
        {
            string query = string.Format("exec ThemGV N'{0}', N'{1}', N'{2}', {3}, N'{4}', {5}, '{6}' ", giaoVien.TenGV, giaoVien.DiaChi, giaoVien.GioiTinh, giaoVien.Sdt, giaoVien.ChucVu, 0, giaoVien.MaMon);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool SuaGV(GiaoVien giaoVien)
        {
            string query = string.Format("exec SuaGV '{0}', N'{1}', N'{2}', N'{3}', '{4}', N'{5}', {6}, '{7}' ", giaoVien.MaGV, giaoVien.TenGV, giaoVien.DiaChi, giaoVien.GioiTinh, giaoVien.Sdt, giaoVien.ChucVu, 0, giaoVien.MaMon);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<GiaoVien> XemTatCaGV()
        {
            string query = string.Format("exec XemTatCaGV ");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new GiaoVien(m.Field<string>("MaGV"), m.Field<string>("TenGV"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("ChucVu"), m.Field<string>("MaMon"))).ToList();
        }

        public List<string> XemDanhSachTenGV()
        {
            string query = string.Format("exec GetDanhSachTenGV ");
            return ConvertString(DataProvider.Instance.ExecuteQuery(query));
        }

        public List<string> ConvertString(DataTable datatable)
        {
            List<string> list = new List<string>();
            foreach (DataRow dr in datatable.Rows)
            {
                list.Add(dr[0].ToString());
            }
            return list;
        }

        public GiaoVien XemChiTietGV(string maGV)
        {
            string query = string.Format("exec XemChiTietGV '{0}' ", maGV);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            GiaoVien gv = new GiaoVien();


            gv.MaGV = dt.Rows[0]["MaGV"].ToString();
            gv.TenGV = dt.Rows[0]["TenGV"].ToString();
            gv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            gv.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            gv.Sdt = dt.Rows[0]["SDT"].ToString();
            gv.ChucVu = dt.Rows[0]["GioiTinh"].ToString();
            gv.MaMon = dt.Rows[0]["MaMon"].ToString();

            return gv;
        }

        public DataTable XemTatCaMonHoc()
        {
            string query = string.Format("exec XemTatCaMonHoc ");

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

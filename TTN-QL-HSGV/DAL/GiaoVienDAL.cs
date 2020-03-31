using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.DAL
{
    class GiaoVienDAL
    {
        public bool ThemGV(GiaoVien giaoVien)
        {
            string query = string.Format("exec ThemGV N'{0}', N'{1}', N'{2}', {3}, N'{4}', {5}, {6} ", giaoVien.TenGV, giaoVien.DiaChi, giaoVien.GioiTinh, giaoVien.Sdt, giaoVien.ChucVu, 0, giaoVien.MaMon);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool SuaGV(GiaoVien giaoVien)
        {
            string query = string.Format("exec SuaGV {0}, N'{1}', N'{2}', N'{3}', '{4}', N'{5}', {6}, {7} ", giaoVien.MaGV, giaoVien.TenGV, giaoVien.DiaChi, giaoVien.GioiTinh, giaoVien.Sdt, giaoVien.ChucVu, 0, giaoVien.MaMon);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<GiaoVien> XemTatCaGV()
        {
            string query = string.Format("exec XemTatCaGV ");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select( m => 
            new GiaoVien(m.Field<int>("MaGV"), m.Field<string>("TenGV"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("ChucVu"), m.Field<int>("MaMon"))).ToList();
        }

        public GiaoVien XemChiTietGV(int maGV)
        {
            string query = string.Format("exec XemChiTietGV {0} ", maGV);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            GiaoVien gv = new GiaoVien();


            gv.MaGV = Int16.Parse(dt.Rows[0]["MaGV"].ToString());
            gv.TenGV = dt.Rows[0]["TenGV"].ToString();
            gv.DiaChi= dt.Rows[0]["DiaChi"].ToString();
            gv.GioiTinh= dt.Rows[0]["GioiTinh"].ToString();
            gv.Sdt= dt.Rows[0]["SDT"].ToString();
            gv.ChucVu = dt.Rows[0]["GioiTinh"].ToString();
            gv.MaMon = int.Parse(dt.Rows[0]["MaMon"].ToString());

            return gv;
        }

        public DataTable LayChucVu()
        {
            string query = string.Format("exec LayChucVu ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        //public List<GiaoVien> SearchGiaoVien(string gioiTinh, string chucVu, int maMon)
        //{
        //    List<GiaoVien> gv = new List<GiaoVien>();

        //    string query = string.Format("exec SearchGiaoVien N'{0}', N'{1}', {0} ", gioiTinh, chucVu, maMon);

        //    return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
        //   new GiaoVien(m.Field<int>("MaGV"), m.Field<string>("TenGV"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("ChucVu"), m.Field<int>("MaMon"))).ToList();
        //}
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HKOJN4O;Initial Catalog=TTN_QLHSGV;Integrated Security=True");

        public List<GiaoVien> SearchGiaoVien(string gioitinh, string chucvu, int mamon)
        {
            List<GiaoVien> gv = new List<GiaoVien>();
            string query;
            sqlConnection.Open();

            query = "exec SearchGiaoVien N'" + gioitinh + "', N'" + chucvu + "', " + mamon;

            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    gv.Add(new GiaoVien((int)reader["MaGV"], (string)reader["TenGV"], (string)reader["DiaChi"], (string)reader["GioiTinh"], (string)reader["SDT"], (string)reader["ChucVu"], (int)reader["MaMon"]));
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return gv;
        }
    }
}

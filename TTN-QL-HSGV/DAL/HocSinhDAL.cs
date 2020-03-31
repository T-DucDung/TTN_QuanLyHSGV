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
    class HocSinhDAL
    {
        public bool ThemHS(HocSinh hocSinh)
        {
            string query = string.Format("exec ThemHS N'{0}', N'{1}', N'{2}', '{3}', {4}, {5} ", hocSinh.TenHS, hocSinh.DiaChi, hocSinh.GioiTinh, hocSinh.Sdt, 0, hocSinh.MaLop);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool SuaHS(HocSinh hocSinh)
        {
            string query = string.Format("exec SuaHS {0}, N'{1}', N'{2}', N'{3}', '{4}', {5}, {6} ", hocSinh.MaHS, hocSinh.TenHS, hocSinh.DiaChi, hocSinh.GioiTinh, hocSinh.Sdt, 0, hocSinh.MaLop);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<HocSinh> XemTatCaHS()
        {
            string query = string.Format("exec XemTatCaHS ");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new HocSinh(m.Field<int>("MaHS"), m.Field<string>("TenHS"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<int>("MaLop"))).ToList();
        }

        public HocSinh XemChiTietHS(int maHS)
        {
            string query = string.Format("exec XemChiTietHS {0} ", maHS);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            HocSinh hs = new HocSinh();

            hs.MaHS = Int16.Parse(dt.Rows[0]["MaHS"].ToString());
            hs.TenHS = dt.Rows[0]["TenHS"].ToString();
            hs.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            hs.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            hs.Sdt = dt.Rows[0]["SDT"].ToString();
            hs.MaLop = int.Parse(dt.Rows[0]["MaLop"].ToString());

            return hs;
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HKOJN4O;Initial Catalog=TTN_QLHSGV;Integrated Security=True");

        public List<HocSinh> SearchHocSinh(string gioitinh, int malop, int makhoahoc)
        {
            List<HocSinh> hs = new List<HocSinh>();
            string query;
            sqlConnection.Open();

            query = "exec SearchHocSinh N'" + gioitinh + "', " + malop + ", " + makhoahoc;

            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    hs.Add(new HocSinh((int)reader["MaHS"], (string)reader["TenHS"], (string)reader["DiaChi"], (string)reader["GioiTinh"], (string)reader["SDT"], (int)reader["MaLop"]));
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            return hs;
        }
    }
}

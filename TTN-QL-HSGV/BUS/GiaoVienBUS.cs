using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        public bool ThemGV(GiaoVien giaoVien,byte[] img)
        {
            string query = string.Format("exec ThemGV N'{0}', N'{1}', N'{2}', {3}, N'{4}', @AnhDaiDien, '{5}' ", giaoVien.TenGV, giaoVien.DiaChi, giaoVien.GioiTinh, giaoVien.Sdt, giaoVien.ChucVu , giaoVien.MaMon);
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@AnhDaiDien", img);
            return DataProvider.Instance.ExecuteNonQuery(command) > 0;
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
            gv.ChucVu = dt.Rows[0]["ChucVu"].ToString();
            gv.MaMon = dt.Rows[0]["MaMon"].ToString();

            return gv;
        }

        public Image XemAnhGV(string maGV)
        {
            string query = string.Format("exec XemAnhGV '{0}' ", maGV);
            DataTable obj = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = obj.Rows[0];
            try{
                byte[] img = (byte[])row[0];
                return byteArrayToImage(img);
            }
            catch
            {
                return byteArrayToImage(new byte[1]);
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception ex)
            {
                Bitmap bmp = new Bitmap(90, 130);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    Rectangle ImageSize = new Rectangle(0, 0, 90, 130);
                    graph.FillRectangle(Brushes.White, ImageSize);
                }
                return bmp;
            }
        }

        public DataTable XemTatCaMonHoc()
        {
            string query = string.Format("exec XemTatCaMonHoc ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayChucVu()
        {
            string query = string.Format("exec LayChucVu ");

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

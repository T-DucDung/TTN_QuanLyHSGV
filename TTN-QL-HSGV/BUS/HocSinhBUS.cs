using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TTN_QL_HSGV.DAL;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.BUS
{
    class HocSinhBUS
    {
        public bool ThemHS(HocSinh hocSinh)
        {
            string query = string.Format("exec ThemHS N'{0}', N'{1}', N'{2}', {3}, {4}, '{5}' ", hocSinh.TenHS, hocSinh.DiaChi, hocSinh.GioiTinh, hocSinh.Sdt, 0 , hocSinh.MaLop);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool ThemHS(HocSinh hocSinh ,byte[] img)
        {
            string query = string.Format("exec  ThemHS @TenHS ,@DiaChi, @GioiTinh,@SDT , @AnhDaiDien , @MaLop");
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@TenHS", hocSinh.TenHS);
            command.Parameters.AddWithValue("@DiaChi", hocSinh.DiaChi);
            command.Parameters.AddWithValue("@GioiTinh", hocSinh.GioiTinh);
            command.Parameters.AddWithValue("@SDT", hocSinh.Sdt);
            command.Parameters.AddWithValue("@AnhDaiDien",img);
            command.Parameters.AddWithValue("@MaLop", hocSinh.MaLop);
            return DataProvider.Instance.ExecuteNonQuery(command) > 0;
        }

        public bool SuaHS(HocSinh hocSinh)
        {
            string query = string.Format("exec SuaHS '{0}', N'{1}', N'{2}', N'{3}', '{4}', {5}, '{6}' ", hocSinh.MaHS, hocSinh.TenHS, hocSinh.DiaChi, hocSinh.GioiTinh, hocSinh.Sdt, 0, hocSinh.MaLop);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool SuaHS(HocSinh hocSinh, byte[] img)
        {
            string query = string.Format("exec SuaHS '{0}', N'{1}', N'{2}', N'{3}', '{4}', @AnhDaiDien , '{5}' ", hocSinh.MaHS, hocSinh.TenHS, hocSinh.DiaChi, hocSinh.GioiTinh, hocSinh.Sdt, hocSinh.MaLop);
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@AnhDaiDien", img);
            return DataProvider.Instance.ExecuteNonQuery(command) > 0;
        }

        public List<HocSinh> XemTatCaHS()
        {
            string query = string.Format("exec XemTatCaHS ");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new HocSinh(m.Field<string>("MaHS"), m.Field<string>("TenHS"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("MaLop")  )).ToList();
        }

        public List<HocSinh> XemTatCaHSLop(string MaLop)
        {
            string query = string.Format("exec GetDanhSachHocSinhLop N'" + MaLop + "'");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new HocSinh(m.Field<string>("MaHS"), m.Field<string>("TenHS"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("MaLop"))).ToList();
        }

        public List<HocSinh> XemTatCaHSGT(string Gt)
        {
            string query = string.Format("exec GetDanhSachHocSinhGt N'" + Gt + "'");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new HocSinh(m.Field<string>("MaHS"), m.Field<string>("TenHS"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("MaLop"))).ToList();
        }

        // get all hocsinh + mon hoc
        public List<HocSinh_KhoaHoc> XemTatCaHS_KhoaHoc()
        {
            string query = string.Format("exec XemTatCaHS ");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new HocSinh_KhoaHoc(m.Field<string>("MaHS"), m.Field<string>("TenHS"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("MaLop"), m.Field<string>("TenKH"), m.Field<string>("MaKH"))).ToList();
        }

        public List<HocSinh> XemTatCaHSLopGT(string MaLop, string Gt)
        {
            string query = string.Format("exec GetDanhSachHocSinhLopGt N'" + MaLop + "',N'" + Gt +"'");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new HocSinh(m.Field<string>("MaHS"), m.Field<string>("TenHS"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("MaLop"))).ToList();
        }



        public HocSinh XemChiTietHS(string maHS)
        {
            string query = string.Format("exec XemChiTietHS '{0}' ", maHS);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            HocSinh hs = new HocSinh();


            hs.MaHS = dt.Rows[0]["MaHS"].ToString();
            hs.TenHS = dt.Rows[0]["TenHS"].ToString();
            hs.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            hs.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            hs.Sdt = dt.Rows[0]["SDT"].ToString();
            hs.MaLop = dt.Rows[0]["MaLop"].ToString();

            return hs;
        }

        public Image XemAnhHS(string maHS)
        {
            string query = string.Format("exec XemAnhHS '{0}' ", maHS);
            DataTable obj = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = obj.Rows[0];
            try
            {
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
            catch(Exception ex)
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

        public DataTable XemTatCaLopHoc()
        {
            string query = string.Format("exec XemTatCaLopHoc ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable XemTatCaKhoaHoc()
        {
            string query = string.Format("exec XemTatCaKhoaHoc ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}

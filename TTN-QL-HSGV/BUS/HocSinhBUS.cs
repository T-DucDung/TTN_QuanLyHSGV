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
    class HocSinhBUS
    {
        public bool ThemHS(HocSinh hocSinh)
        {
            string query = string.Format("exec ThemHS N'{0}', N'{1}', N'{2}', {3}, {4}, '{5}' ", hocSinh.TenHS, hocSinh.DiaChi, hocSinh.GioiTinh, hocSinh.Sdt, 0, hocSinh.MaLop);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool SuaHS(HocSinh hocSinh)
        {
            string query = string.Format("exec SuaHS '{0}', N'{1}', N'{2}', N'{3}', '{4}', {5}, '{6}' ", hocSinh.MaHS, hocSinh.TenHS, hocSinh.DiaChi, hocSinh.GioiTinh, hocSinh.Sdt, 0, hocSinh.MaLop);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
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

        public List<HocSinh> XemTatCaHSLop(string MaLop)
        {
            string query = string.Format("exec GetDanhSachHocSinhLop N'" + MaLop + "'");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new HocSinh(m.Field<string>("MaHS"), m.Field<string>("TenHS"), m.Field<string>("DiaChi"), m.Field<string>("GioiTinh"), m.Field<string>("SDT"), m.Field<string>("MaLop"))).ToList();
        }


    }
}

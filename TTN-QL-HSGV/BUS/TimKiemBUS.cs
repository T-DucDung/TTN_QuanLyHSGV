using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.BUS
{
    class TimKiemBUS
    {
        private static void XuLyDauVao1(ref string HoTen, ref string GioiTinh, ref string Lop, ref string KhoaHoc)
        {
            if (HoTen == "") HoTen = "%";
            else HoTen = "%" + HoTen + "%";
            if (Lop == "") Lop = "%";
            else Lop = "%" + Lop + "%";
            if (GioiTinh == "None") GioiTinh = "%";
            if (KhoaHoc == "") KhoaHoc = "%";
            else KhoaHoc = "%" + KhoaHoc + "%";
        }
        private static void XuLyDauVao2(ref string HoTen, ref string GioiTinh)
        {
            if (HoTen == "") HoTen = "%";
            else HoTen = "%" + HoTen + "%";
            if (GioiTinh == "None") GioiTinh = "%";
        }
        public static DataTable TimKiemKoThongTin()
        {
            DataTable result = new DataTable();

            DataTable dtgv = new DataTable();
            dtgv = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaGV as Mã,TenGV as Họ_Tên,GioiTinh as Giới_Tính,SDT,DiaChi as Địa_Chỉ " +
                "from GIAOVIEN " +
                "where " +
                "TenGV like N'%'");
            dtgv.Columns.Add("Chức Vụ", typeof(string));
            int count_r1 = dtgv.Rows.Count;
            for (int i = 0; i < count_r1; i++)
            {
                dtgv.Rows[i][5] = "Giáo Viên";
            }

            DataTable dths = new DataTable();
            dths = DAL.DataProvider.Instance.ExecuteQuery("" +
               "select MaHS as Mã,TenHS as Họ_Tên,GioiTinh as Giới_Tính,SDT,DiaChi as Địa_Chỉ " +
               "from HOCSINH " +
               "where " +
               "TenHS like N'%'");
            dths.Columns.Add("Chức Vụ", typeof(string));
            int count_r2 = dths.Rows.Count;
            for (int i = 0; i < count_r2; i++)
            {
                dths.Rows[i][5] = "Học Sinh";
            }
            result.Merge(dths);
            result.Merge(dtgv);
            
            return result;
        }
        public static DataTable TimKiemThongTinDungLop(string HoTen,string GioiTinh,string Lop,string KhoaHoc)
        {
            XuLyDauVao1(ref HoTen,ref GioiTinh,ref Lop,ref KhoaHoc);

            DataTable Result = new DataTable();
            DataTable dths = new DataTable();
            dths = TimKiemHocSinhDungLop(HoTen, GioiTinh, Lop, KhoaHoc);
            dths.Columns.Add("Chức Vụ", typeof(string));
            int count_r2 = dths.Rows.Count;
            for (int i = 0; i < count_r2; i++)
            {
                dths.Rows[i][5] = "Học Sinh";
            }
            DataTable dtgv = new DataTable();
            dtgv = TimKiemGiaoVienDungLop(HoTen, GioiTinh, Lop, KhoaHoc);
            dtgv.Columns.Add("Chức Vụ", typeof(string));
            int count_r1 = dtgv.Rows.Count;
            for (int i = 0; i < count_r1; i++)
            {
                dtgv.Rows[i][5] = "Giáo Viên";
            }
            Result.Merge(dths);
            Result.Merge(dtgv);
            return Result;
        }
        public static DataTable TimKiemThongTinKoDungLop(string HoTen, string GioiTinh)
        {

            XuLyDauVao2(ref HoTen, ref GioiTinh);
            /*if (HoTen == "") HoTen = "%";
            else HoTen = "%" + HoTen + "%";
            if (GioiTinh == "None") GioiTinh = "%";*/

            DataTable Result = new DataTable();

            DataTable dths = new DataTable();
            dths = TimKiemHocSinhKoDungLop(HoTen, GioiTinh);
            dths.Columns.Add("Chức Vụ", typeof(string));
            int count_r2 = dths.Rows.Count;
            for (int i = 0; i < count_r2; i++)
            {
                dths.Rows[i][5] = "Học Sinh";
            }
            DataTable dtgv = new DataTable();
            dtgv = TimKiemGiaoVienKoDungLop(HoTen, GioiTinh);
            dtgv.Columns.Add("Chức Vụ", typeof(string));
            int count_r1 = dtgv.Rows.Count;
            for (int i = 0; i < count_r1; i++)
            {
                dtgv.Rows[i][5] = "Giáo Viên";
            }
            Result.Merge(dths);
            Result.Merge(dtgv);
            
            return Result;
            
        }
        private static DataTable TimKiemHocSinhKoDungLop(string HoTen,string GioiTinh)
        {
            DataTable Result = new DataTable();
            Result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaHS as Mã,TenHS as Họ_Tên,GioiTinh as Giới_Tính,SDT,DiaChi as Địa_Chỉ " +
                "from HOCSINH " +
                "where " +
                $"HOCSINH.TenHS like N'{HoTen}' " +
                "and " +
                $"HOCSINH.GioiTinh like N'{GioiTinh}' ");
            return Result;
        }
        private static DataTable TimKiemHocSinhDungLop(string HoTen, string GioiTinh, string Lop, string KhoaHoc)
        {
            DataTable Result = new DataTable();
            Result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaHS as Mã,TenHS as Họ_Tên,GioiTinh as Giới_Tính,SDT,DiaChi as Địa_Chỉ " +
                "from HOCSINh " +
                "where " +
                $"KHOAHOC.TenKH like '{KhoaHoc}' " +
                "and " +
                "LOP.MaKH = KHOAHOC.MaKH " +
                "and " +
                $"LOP.TenLop like '{Lop}' " +
                "and " +
                "HOCSINH.MaLop = LOP.MaLop " +
                $"HOCSINH.TenHS like N'{HoTen}' " +
                "and " +
                $"HOCSINH.GioiTinh like N'{GioiTinh}' ");
            return Result;
        }
        private static DataTable TimKiemGiaoVienKoDungLop(string HoTen, string GioiTinh)
        { 
            DataTable Result = new DataTable();
            Result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaGV as Mã,TenGV as Họ_Tên,GioiTinh as Giới_Tính,SDT,DiaChi as Địa_Chỉ  " +
                "from GIAOVIEN " +
                "where " +
                $"GIAOVIEN.TenGV like N'{HoTen}' " +
                "and " +
                $"GIAOVIEN.GioiTinh like N'{GioiTinh}' ");
            return Result;
        }
        private static DataTable TimKiemGiaoVienDungLop(string HoTen, string GioiTinh,string Lop,string KhoaHoc)
        {
            DataTable Result = new DataTable();
            Result = DAL.DataProvider.Instance.ExecuteQuery("" +
                "select MaGV as Mã,TenGV as Họ_Tên,GioiTinh as Giới_Tính,SDT,DiaChi as Địa_Chỉ  " +
                "from GIAOVIEN " +
                "where " +
                $"KHOAHOC.TenKH like '{KhoaHoc}' " +
                "and " +
                "LOP.MaKH = KHOAHOC.MaKH " +
                "and " +
                $"LOP.TenLop like '{Lop}' " +
                "and " +
                "Lop.MaLop = GIANGDAY.MaLop " +
                "and " +
                "GIANGDAY.MaGV = GIAOVIEN.MaGV " +
                "and " +
                $"GIAOVIEN.GioiTinh like N'{GioiTinh}' " +
                "and " +
                $"GIAOVIEN.TenGV like '{HoTen}' ");
            return Result;
        }
    }
}

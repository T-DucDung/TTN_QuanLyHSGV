using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QL_HSGV.DAL;
using System.Data;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.BUS
{
    class LopBUS : IConverter<Lop>
    {
        public List<Lop> Convert(DataTable datatable)
        {
            List<Lop> lops = new List<Lop>();
            lops = (from DataRow dr in datatable.Rows
                    select new Lop()
                    {
                        MaLop = dr["MaLop"].ToString(),
                        TenLop = dr["TenLop"].ToString(),
                        MaGVCN = dr["MaGVCN"].ToString(),
                        MaKhoaHoc = dr["MaKH"].ToString()
                    }).ToList();
            return lops;
        }

        public List<string> ConvertString(DataTable datatable)
        {
            List<string> khoahocs = new List<string>();
            khoahocs.Add("None");
            foreach (DataRow dr in datatable.Rows)
            {
                khoahocs.Add(dr[0].ToString());
            }
            return khoahocs;
        }

        public List<Lop> GetDanhSachLop()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("GetDanhSachLop");
            return Convert(dataTable);
        }

        public List<Lop> GetDanhSachLop(string KhoaHoc)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("GetDanhSachLopTheoKhoa N'" + KhoaHoc +"'");
            return Convert(dataTable);
        }

        public string GetTenGiaoVien(string MaLop)
        {
            object obj =  DataProvider.Instance.ExecuteScalar("GetGVCN " + "'" + MaLop + "'");
            if(obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return "";
            }
        }

        public List<string> GetDanhSachKhoaHoc()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("GetDanhSachKhoaHoc");
            return ConvertString(dataTable);
        }
    }
}

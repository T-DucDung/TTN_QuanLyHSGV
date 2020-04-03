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
            List<string> list = new List<string>();
            foreach (DataRow dr in datatable.Rows)
            {
                list.Add(dr[1].ToString());
            }
            return list;
        }


        public List<Lop> GetDanhSachLop()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("GetDanhSachLop");
            return Convert(dataTable);
        }

        public List<string> GetDanhSachLopString()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("GetDanhSachLop");
            return ConvertString(dataTable);
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

        public void UpdateLop(string malop, string tenlop, string tengvcn, string tenkhoahoc)
        {
            DataProvider.Instance.ExecuteNonQuery("UpdateLop '" + malop + "','" + tenlop + "','" + tengvcn + "',N'" + tenkhoahoc + "'");
        }

        public string ThemLop(string tenlop, string magvcn, string tenkhochoc)
        {
            object obj =  DataProvider.Instance.ExecuteScalar("AddLop N'" + tenlop + "','" + magvcn + "',N'" + tenkhochoc + "'");
            if (obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return "";
            }    
        }

        public string GetTenLop(string MaLop)
        {
            object obj = DataProvider.Instance.ExecuteScalar("GetTenLop '" + MaLop + "'").ToString();
            if (obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}

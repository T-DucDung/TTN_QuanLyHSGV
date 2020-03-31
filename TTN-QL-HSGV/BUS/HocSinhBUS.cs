using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QL_HSGV.DAL;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.BUS
{
    class HocSinhBUS
    {
        HocSinhDAL hs = new HocSinhDAL();
        public bool ThemHS(HocSinh hocSinh)
        {
            return hs.ThemHS(hocSinh);
        }

        public bool SuaHS(HocSinh hocSinh)
        {
            return hs.SuaHS(hocSinh);
        }

        public List<HocSinh> XemTatCaHS()
        {
            return hs.XemTatCaHS();
        }

        public HocSinh XemChiTietHS(int maHS)
        {
            return hs.XemChiTietHS(maHS);
        }

        public List<HocSinh> SearchHocSinh(string gioiTinh, int maLop, int maKhoa)
        {
            return hs.SearchHocSinh(gioiTinh, maLop, maKhoa);
        }

    }
}

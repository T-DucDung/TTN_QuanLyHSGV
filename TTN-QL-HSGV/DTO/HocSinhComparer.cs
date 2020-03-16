using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.DTO
{
    class HocSinhComparer: IComparer<HocSinh>
    {
        private string memberName = string.Empty;
        private SortOrder sortOrder = SortOrder.None;

        public HocSinhComparer(string memberName, SortOrder sortOrder)
        {
            this.memberName = memberName;
            this.sortOrder = sortOrder;
        }

        public int Compare(HocSinh x, HocSinh y)
        {
            switch (memberName)
            {
                case "TenHS":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.TenHS.CompareTo(y.TenHS);
                        }
                        else
                        {
                            return y.TenHS.CompareTo(x.TenHS);
                        }
                    }
                case "DiaChi":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.DiaChi.CompareTo(y.DiaChi);
                        }
                        else
                        {
                            return y.DiaChi.CompareTo(x.DiaChi);
                        }
                    }
                case "GioiTinh":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.GioiTinh.CompareTo(y.GioiTinh);
                        }
                        else
                        {
                            return y.GioiTinh.CompareTo(x.GioiTinh);
                        }
                    }
                case "SDT":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.Sdt.CompareTo(y.Sdt);
                        }
                        else
                        {
                            return y.Sdt.CompareTo(x.Sdt);
                        }
                    }
                case "MaLop":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.MaLop.CompareTo(y.MaLop);
                        }
                        else
                        {
                            return y.MaLop.CompareTo(x.MaLop);
                        }
                    }
                default:
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.MaHS.CompareTo(y.MaHS);
                        }
                        else
                        {
                            return y.MaHS.CompareTo(x.MaHS);
                        }
                    }
            }
        }
    }
}

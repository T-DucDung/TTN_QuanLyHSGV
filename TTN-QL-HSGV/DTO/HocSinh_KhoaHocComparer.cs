using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.DTO
{
    class HocSinh_KhoaHocComparer : IComparer<HocSinh_KhoaHoc>
    {
        private string memberName = string.Empty;
        private SortOrder sortOrder = SortOrder.None;

        public HocSinh_KhoaHocComparer(string memberName, SortOrder sortOrder)
        {
            this.memberName = memberName;
            this.sortOrder = sortOrder;
        }
        public int Compare(HocSinh_KhoaHoc x, HocSinh_KhoaHoc y)
        {
            switch (memberName)
            {
                case "MaKH":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.MaKH.CompareTo(y.MaKH);
                        }
                        else
                        {
                            return y.MaKH.CompareTo(x.MaKH);
                        }
                    }
                case "TenKH":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.TenKH.CompareTo(y.TenKH);
                        }
                        else
                        {
                            return y.TenKH.CompareTo(x.TenKH);
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

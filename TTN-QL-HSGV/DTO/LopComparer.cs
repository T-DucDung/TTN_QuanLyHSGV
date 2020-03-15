using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.DTO
{
    class LopComparer : IComparer<Lop>
    {

        private string memberName = string.Empty;
        private SortOrder sortOrder = SortOrder.None;

        public LopComparer(string memberName, SortOrder sortOrder)
        {
            this.memberName = memberName;
            this.sortOrder = sortOrder;
        }

        public int Compare(Lop x, Lop y)
        {
            switch(memberName)
            {
                case "TenLop":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.TenLop.CompareTo(y.TenLop);
                        }
                        else
                        {
                            return y.TenLop.CompareTo(x.TenLop);
                        }
                    }
                case "MaGVCN":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.MaGVCN.CompareTo(y.MaGVCN);
                        }
                        else
                        {
                            return y.MaGVCN.CompareTo(x.MaGVCN);
                        }
                    }
                case "MaKhoaHoc":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.MaKhoaHoc.CompareTo(y.MaKhoaHoc);
                        }
                        else
                        {
                            return y.MaKhoaHoc.CompareTo(x.MaKhoaHoc);
                        }
                    }
                default:
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
            }
        }
    }
}

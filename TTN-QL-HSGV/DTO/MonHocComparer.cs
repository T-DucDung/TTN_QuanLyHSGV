using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QL_HSGV.DTO
{
    class MonHocComparer : IComparer<MonHoc>
    {

        private string memberName = string.Empty;
        private SortOrder sortOrder = SortOrder.None;

        public MonHocComparer(string memberName, SortOrder sortOrder)
        {
            this.memberName = memberName;
            this.sortOrder = sortOrder;
        }

        public int Compare(MonHoc x, MonHoc y)
        {
            switch (memberName)
            {
                case "TenMon":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.TenMon.CompareTo(y.TenMon);
                        }
                        else
                        {
                            return y.TenMon.CompareTo(x.TenMon);
                        }
                    }
                case "MaKhoa":
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.MaKhoa.CompareTo(y.MaKhoa);
                        }
                        else
                        {
                            return y.MaKhoa.CompareTo(x.MaKhoa);
                        }
                    }
                default:
                    {
                        if (sortOrder == SortOrder.Ascending)
                        {
                            return x.MaMon.CompareTo(y.MaMon);
                        }
                        else
                        {
                            return y.MaMon.CompareTo(x.MaMon);
                        }
                    }
            }
        }
    }
}

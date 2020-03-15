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

            }
        }
    }
}

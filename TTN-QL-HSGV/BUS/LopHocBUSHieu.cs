using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QL_HSGV.DAL;

namespace TTN_QL_HSGV.BUS
{
    class LopHocBUSHieu
    {
        LopHocDALHieu lop = new LopHocDALHieu();

        public DataTable XemTatCaLopHoc()
        {
            return lop.XemTatCaLopHoc();
        }
    }
}

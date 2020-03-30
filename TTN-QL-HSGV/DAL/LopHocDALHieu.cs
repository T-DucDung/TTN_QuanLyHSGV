using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DAL
{
    class LopHocDALHieu
    {
        public DataTable XemTatCaLopHoc()
        {
            string query = string.Format("exec XemTatCaLopHoc ");

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

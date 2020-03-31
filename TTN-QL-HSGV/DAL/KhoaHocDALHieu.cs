using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.DAL
{
    class KhoaHocDALHieu
    {
        public DataTable XemTatCaKhoaHoc()
        {
            string query = string.Format("exec XemTatCaKhoaHoc ");

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

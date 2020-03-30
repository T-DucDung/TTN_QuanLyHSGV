using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QL_HSGV.DTO;

namespace TTN_QL_HSGV.DAL
{
    class MonDALHieu
    {
        public DataTable XemTatCaMonHoc()
        {
            string query = string.Format("exec XemTatCaMonHoc ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}

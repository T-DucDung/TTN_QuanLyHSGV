using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QL_HSGV.BUS
{
    interface IConverter<T>
    {
        List<T> Convert(DataTable datatable);
    }
}

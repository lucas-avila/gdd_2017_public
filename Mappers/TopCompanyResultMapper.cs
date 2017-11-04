using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class TopCompanyResultMapper : StoreResultMapper<TopCompanyResult>
    {

        public TopCompanyResult getMapped(Dictionary<string, object> row)
        {
            TopCompanyResult top = new TopCompanyResult();
            top.name = (String)row["com_name"];
            top.address = (String)row["com_address"];
            top.cuit = (String)row["com_cuit"];
            top.value = Convert.ToDecimal(row["value"]);

            return top;
        }
    }
}

using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class TopClientResultMapper : StoreResultMapper<TopClientResult>
    {

        public TopClientResult getMapped(Dictionary<string, object> row)
        {
            TopClientResult top = new TopClientResult();
            top.name = (String)row["cli_name"];
            top.lastName = (String)row["cli_last_name"];
            top.dni = (int)row["cli_dni"];
            top.value = (int)row["value"];

            return top;
        }
    }
}

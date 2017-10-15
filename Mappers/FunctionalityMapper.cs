using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Model;

namespace PagoAgilFrba.Mappers
{
    class FunctionalityMapper : StoreResultMapper<Functionality>
    {

        public Functionality getMapped(Dictionary<string, object> row)
        {
            Functionality func = new Functionality();
            func.name = (String)row["func_name"];
            return func;
        }
    }
}

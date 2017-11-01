using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class PaymentMethodMapper : StoreResultMapper<PaymentMethod>
    {
        public PaymentMethod getMapped(Dictionary<string, object> row){
            PaymentMethod paym = new PaymentMethod();
            paym.id = (int)row["paym_id"];
            paym.description = (String)row["paym_description"];
            return paym;
        }
    }
}

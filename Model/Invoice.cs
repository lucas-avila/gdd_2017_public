using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Model
{
    class Invoice
    {
        public Decimal nro { get; set; }
        public Decimal amount { get; set; }
        public Decimal total { get; set; }
        public int company_id { get; set; }
        public Decimal fee_percentage { get; set; }

        /*Missing:
            inv_date datetime NOT NULL,
        */
    }
}

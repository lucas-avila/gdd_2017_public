using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Model
{
    class Payment
    {
        public Decimal number { get; set; }
        public int bill_id { get; set; }
        public String branch_name { get; set; }
        public int paym_id { get; set; }
        public Decimal total { get; set; }

        /*Missing:
	        pay_date datetime NOT NULL,
        */
    }
}

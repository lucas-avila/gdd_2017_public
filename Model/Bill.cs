using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Model
{
    class Bill
    {
        public int id { get; set; }
        public Decimal number { get; set; }
        public Decimal cli_dni { get; set; }
        public int com_id { get; set; }
        public Decimal total { get; set; }


        /* Missing:
	    bill_date datetime NOT NULL, 
	    bill_expiration datetime NOT NULL,*/
    }
}

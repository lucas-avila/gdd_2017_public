using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Model
{
    class BillTable
    {
        public int id { get; set; }
        public Decimal number { get; set; }
        public String client { get; set; }
        public String company { get; set; }
        public Decimal total { get; set; }
        public DateTime date { get; set; }
        public DateTime expiration { get; set; }

    }
}

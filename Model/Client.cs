using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Model
{
    class Client
    {
        public int id { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String address { get; set; }
        public DateTime birthday { get; set; }
        public String postCode { get; set; }
        public Decimal dni { get; set; }
    }
}

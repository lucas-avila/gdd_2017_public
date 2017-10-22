using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Model
{
    class Company
    {
        public String name { get; set; }
        public String address { get; set; }
        public String cuit { get; set; }
        public int entry { get; set; }
        public Boolean active { get; set; }
        public int id { get; set; }
    }
}

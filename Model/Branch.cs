﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Branch{

        public int id { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public Decimal postalCode { get; set; }
        public Boolean active { get; set; }
    }
}

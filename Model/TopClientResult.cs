using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Model
{
    class TopClientResult
    {
        public String name { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public int value { get; set; } //Could be percentage or quantity
    }
}

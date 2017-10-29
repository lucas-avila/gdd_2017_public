﻿using System;

namespace PagoAgilFrba.Model
{
    public class Bill
    {
        public int id { get; set; }
        public Decimal number { get; set; }
        public int cli_id { get; set; }
        public int com_id { get; set; }
        public Decimal total { get; set; }
        public DateTime date { get; set; }
        public DateTime expiration { get; set; }

    }
}
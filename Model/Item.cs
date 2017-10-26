using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model{
    public class Item{

        public int? number { get; set; }
        public int? billId { get; set; }
        public Decimal amount { get; set; }
        public Decimal quantity { get; set; }

        public Item() { 
        }

        public Item(Decimal amount, Decimal quantity, int? number = null){
            this.number = number;
            this.amount = amount;
            this.quantity = quantity;
        }

    }
}

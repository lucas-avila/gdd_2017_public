using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoAgilFrba.Utils;

namespace PagoAgilFrba.Mappers
{
    class ItemMapper : StoreResultMapper<Item>
    {
        public Item getMapped(Dictionary<string, object> row)
        {
            Item item = new Item();
            item.number = (int)row["it_number"];
            item.billId = (int)row["it_bill_id"];
            item.quantity = (Decimal)row["it_quantity"];
            item.amount = (Decimal)row["it_amount"];

            return item;
        }
    }
}

using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoAgilFrba.Utils;

namespace PagoAgilFrba.Mappers
{
    class BillMapper : StoreResultMapper<Bill>
    {
        public Bill getMapped(Dictionary<string, object> row)
        {
            Bill bill = new Bill();
            bill.id = (int)row["bill_id"];
            bill.number = (Decimal)row["bill_number"];
            bill.cli_id = (int)row["bill_cli_id"];
            bill.com_id = (int)row["bill_com_id"];
            bill.total = (Decimal)row["bill_total"];
            bill.date = (DateTime)row["bill_date"];
            bill.expiration = (DateTime)row["bill_expiration"];

            return bill;
        }
    }
}
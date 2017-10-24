using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class BillMapper
    {
        public Bill getMapped(Dictionary<string, object> row)
        {
            Bill bill = new Bill();
            bill.id = (int)row["bill_id"];
            bill.number = (Decimal)row["bill_number"];
            bill.cli_dni = (Decimal)row["bill_cli_dni"];
            bill.com_id = (int)row["bill_com_id"];
            bill.total = (Decimal)row["bill_total"];

            // Missing both datetimes...
            return bill;
        }
    }
}

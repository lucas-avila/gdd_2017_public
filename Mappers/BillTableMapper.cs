using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoAgilFrba.Utils;

namespace PagoAgilFrba.Mappers
{
    class BillTableMapper : StoreResultMapper<BillTable>
    {
        public BillTable getMapped(Dictionary<string, object> row)
        {
            BillTable bill = new BillTable();
            bill.id = (int)row["bill_id"];
            bill.number = (Decimal)row["bill_number"];
            bill.client = (String)row["bill_client"];
            bill.company = (String)row["bill_company"];
            bill.total = (Decimal)row["bill_total"];
            bill.date = (DateTime)row["bill_date"];
            bill.expiration = (DateTime)row["bill_expiration"];

            return bill;
        }
    }
}
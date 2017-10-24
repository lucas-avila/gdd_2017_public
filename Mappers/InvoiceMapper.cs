using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class InvoiceMapper
    {
        public Invoice getMapped(Dictionary<string, object> row)
        {
            Invoice invoice = new Invoice();
            invoice.nro = (Decimal)row["inv_nro"];
            invoice.amount = (Decimal)row["inv_amount"];
            invoice.total = (Decimal)row["inv_total"];
            invoice.company_id = (int)row["inv_company_id"];
            invoice.fee_percentage = (Decimal)row["inv_fee_percentage"];

            // Missing one datetime...
            return invoice;
        }
    }
}

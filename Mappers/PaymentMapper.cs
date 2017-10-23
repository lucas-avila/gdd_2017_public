using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class PaymentMapper
    {
        public Payment getMapped(Dictionary<string, object> row)
        {
            Payment payment = new Payment();
            payment.number = (Decimal)row["pay_number"];
            payment.bill_id = (int)row["pay_bill_id"];
            payment.branch_name = (String)row["pay_branch_name"];
            payment.paym_id = (int)row["pay_paym_id"];
            payment.total = (Decimal)row["pay_total"];

            // Missing one datetime...
            return payment;
        }
    }
}

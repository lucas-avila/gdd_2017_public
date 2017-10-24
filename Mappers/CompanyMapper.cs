using PagoAgilFrba.Model;
using PagoAgilFrba.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgilFrba.Mappers
{
    class CompanyMapper : StoreResultMapper<Company>
    {

        public Company getMapped(Dictionary<string, object> row)
        {
            Company company = new Company();
            company.address = (String)row["com_address"];
            company.entry = (int)row["com_ent_id"];
            company.cuit = (String)row["com_cuit"];
            company.active = (Boolean)row["com_active"];
            company.id = (int )row["com_id"];
            company.name = (String)row["com_name"];
            return company;
        }
    }
}

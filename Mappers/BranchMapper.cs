using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Model;

namespace PagoAgilFrba.Mappers
{
    class BranchMapper: StoreResultMapper<Branch>{
        
        public Branch getMapped(Dictionary<string, object> row){
            Branch branch = new Branch();
            branch.address = (String) row["branch_address"];
            branch.name = (String) row["branch_name"];
            branch.postalCode = (Decimal)row["branch_postal_code"];
            branch.active = (Boolean)row["branch_active"];
            return branch;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Model;

namespace PagoAgilFrba.Mappers
{

    class RoleMapper: StoreResultMapper<Role>{

        public Role getMapped(Dictionary<string, object> row){
            Role role = new Role();
            role.id = (int)row["role_id"];
            role.active = (Boolean)row["role_active"];
            role.name = (String)row["role_name"];
            return role;
        }
    }
}

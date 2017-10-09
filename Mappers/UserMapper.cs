using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Utils;
using PagoAgilFrba.Model;

namespace PagoAgilFrba.Mappers
{
    class UserMapper: StoreResultMapper<User>{

        public User getMapped(Dictionary<string, object> row){
            User user = new User();
            user.password = (String)row["user_password"];
            user.userName = (String)row["user_username"];
            user.userAttempts = (int)row["user_login_attempts"];
            user.active = (Boolean)row["user_active"];

            return user;
        }
    }
}

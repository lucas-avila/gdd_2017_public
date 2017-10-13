using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class User{

        public String userName { get; set; }
        public String password { get; set; }
        public Boolean active { get; set; }
        public int id { get; set; }
        public int userAttempts { get; set; }
        public Role actualRole { get; set; }
        public Branch actualBranch { get; set; }

    }
}

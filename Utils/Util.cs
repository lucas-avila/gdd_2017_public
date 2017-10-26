using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PagoAgilFrba.Utils
{
    class Util{

        static DateTime sysDate = DateTime.Parse(ConfigurationManager.AppSettings["fechaSistema"]);

        public static decimal? convertStringToNumber(String theString){
            decimal retval;
            bool isDecimal = Decimal.TryParse(theString, out retval);

            if (isDecimal){
                return retval;
            }

            return null;
        }

        public static DateTime getSysDate() {
            return sysDate;
        }
    }
}

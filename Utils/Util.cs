using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PagoAgilFrba.Utils
{
    public class Util{

        static DateTime sysDate = DateTime.Parse(ConfigurationManager.AppSettings["fechaSistema"]);

        public static decimal? convertStringToNumber(String theString){
            decimal retval;
            bool isDecimal = Decimal.TryParse(theString, out retval);

            if (isDecimal){
                return retval;
            }

            return null;
        }

        public static Boolean numberInRange(Decimal minRange, Decimal maxRange, Decimal number) {
            return number >= minRange && number <= maxRange;
        }

        public static Boolean numberInRange(Decimal number) {
            return Util.numberInRange(0, new Decimal(9999999999999999.99), number);
        }

        public static DateTime getSysDate() {
            return sysDate;
        }
    }
}

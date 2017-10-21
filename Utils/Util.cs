using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Utils
{
    class Util{

        public static decimal? convertStringToNumber(String theString){
            decimal retval;
            bool isDecimal = Decimal.TryParse(theString, out retval);

            if (isDecimal){
                return retval;
            }

            return null;
        }
    }
}

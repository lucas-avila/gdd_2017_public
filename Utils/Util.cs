using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Utils
{
    class Util{

        public static int? convertStringToNumber(String theString){
            int retval;
            bool isInt = Int32.TryParse(theString, out retval);

            if (isInt) {
                return retval;
            }

            return null;
        }
    }
}

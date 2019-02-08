using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SamrawitUtilityLibrary
{   

    public class Strings { 


        public static bool ValidUSZipCode(string ValidUSZipCode)
    {
        Regex regex = new Regex(@"^\d{ 5 }(-?\d{ 4})?");
        var match = regex.IsMatch(ValidUSZipCode);
        return match;
    }


        public static bool ValidUSPhoneNumber(string PhoneNumber)
         {
                 Regex regex = new Regex(@"^ (\d{3 } -)?\d{ 3} -\d{4}");
                 var match = regex.IsMatch(PhoneNumber);
                  return match;
         }

        public static bool EqualIgnoreCase(string strA, string strB)
        {
                var result = String.Compare(strA.ToUpper(), strB.ToUpper());
                bool returnResult;
                if(result== 0)
            {
                returnResult = true;
            }
            else
            {
                returnResult = false;
            }
            return returnResult;
        }
    }
}

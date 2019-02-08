using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamrawitUtilityLibrary;

namespace TestSamrawitUtilityLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] zips = { "12345", "123456789", "12345-6789" };
            foreach(var zip in zips)
            {
                Console.WriteLine($"{zip} is" + (Strings.ValidUSZipCode(zip) ? "" : "not") + "valid");
            }

           
            var Phone1 = "322-8888";
            var Phone1Valid = Strings.ValidUSPhoneNumber(Phone1);
            if (Phone1Valid)
            {
                Console.WriteLine($"{Phone1} is valid");
            }

            else
            {
                Console.WriteLine($"{Phone1} is not valid");
            }
            var Phone2 = "513-322-8888";
            var Phone2Valid = Strings.ValidUSPhoneNumber(Phone2);
            if (Phone2Valid)
            {
                Console.WriteLine($"{Phone2} is valid");
                }
                else{
                    Console.WriteLine($" {Phone2} is not vaild");
                }

            
            
          var result =  Strings.EqualIgnoreCase("ABC", "abc");
            if (result == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");

                 
            }
            
            Console.ReadKey();
        }
    }
}






//// creating strings. inorder for strings to be equal they have to be in the same length.
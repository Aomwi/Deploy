using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputOXinEmpty
{
    class Input
    {
        public void InputO(String O)
        {
            Console.WriteLine("\t>>O");
        }

         public static string Evaluate(string input)
         {
               if (input == "O")
                        return "OK";
                  else
                        return "Not OK";

          }
        
        public void InputX(String x)
        {

            Console.WriteLine("\t>>X");
        
        }
    }
}

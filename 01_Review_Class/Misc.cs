using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Review_Class
{ 
    // change internaol to public
    public class Misc
    {
        public static bool CheckRange(int x)
        {
            //return true if number is in the range 10-20 inclusive
            //else return false

            if (x>=10 && x<=20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

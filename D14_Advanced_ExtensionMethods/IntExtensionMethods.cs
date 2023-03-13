using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14_Advanced_ExtensionMethods
{
    internal static class IntExtensionMethods
    {
        internal static int MyAdd(this int number01, int number02, int number03 = 0)
        { 
            return number01 + number02 + number03;
        }

        internal static int MySubtract(this int number01, int number02)
        { 
            return number01- number02;
        }

        internal static int MyMultiply(this int number01, int number02)
        {
            return number01 * number02;
        }

        internal static int MyDevide(this int number01, int number02)
        {
            int devide = 0;
            if (number02 == 0)
            {
                Console.WriteLine("Impossible to devide by zero.");
            }
            else
            {
                devide = number01 / number02;
            }
            return devide;
        }
    }
}

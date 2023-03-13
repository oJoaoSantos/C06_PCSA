using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D14_Advanced_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Int
            int n = 10;      // Este é o this dos methods

            Utility.WriteTitle("Sum this (10) 1");
            //Console.WriteLine(IntExtensionMethods.MyAdd(n, 1, 2));
            Console.WriteLine(n.MyAdd(1));
            Utility.WriteTitle("Sum this (10) 1, 2 ");
            Console.WriteLine(n.MyAdd(1, 2));


            Utility.WriteTitle("Subtract this (10) 1");
            //Console.WriteLine(IntExtensionMethods.MySubtract(n, 1));
            Console.WriteLine(n.MySubtract(1));

            Utility.WriteTitle("Multiply this (10) 2");
            //Console.WriteLine(IntExtensionMethods.MyMultiply(n, 2));
            Console.WriteLine(n.MyMultiply(2));

            Utility.WriteTitle("Devide this (10) 2");
            //Console.WriteLine(IntExtensionMethods.MyDevide(n, 2));
            Console.WriteLine(n.MyDevide(2));
            #endregion

           

            Utility.TerminateConsole();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using D14_Advanced_ExtensionMethods;

namespace E07_DataTypeExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            string stg = "João";
            Utility.WriteTitle("Concatenar e Tornar Maiúsculo this (João) com 'Pedro'");
            Console.WriteLine(stg.ConcatenarMaiusculas("Pedro"));

            Utility.BlockSeparator(2);
            
            int euro = 1;
            Utility.WriteTitle("Formatar para Euro this (1) com 50");
            Console.WriteLine(euro.FormatarParaEuro(50));

            double euroDouble = 1.50;
            Utility.WriteTitle("Formatar para Euro this double(1.50)");
            Console.WriteLine(euroDouble.FormatarParaEuro());

            Utility.TerminateConsole();
        }
    }
}

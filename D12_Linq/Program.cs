using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            HelloWorld helloWorldSintax = new HelloWorld();

            helloWorldSintax.HelloWorldMethodSintax();
            
            helloWorldSintax.HelloWorldQuerySintax();

            List<string> names = ShortNames.CreateNames();
            
            ShortNames.ListNames(names);

            int min = ShortNames.FindShortName(names);

            ShortNames.ListShortNames(names, min);

            Utility.TerminateConsole();
        }
    }
}

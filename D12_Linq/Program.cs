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
            
            #region Hello World
            HelloWorld helloWorldSintax = new HelloWorld();

            helloWorldSintax.HelloWorldMethodSintax();

            helloWorldSintax.HelloWorldQuerySintax();
            #endregion

            #region Short Names
            List<string> names = ShortNames.CreateNames();

            ShortNames.ListNames(names);

            ShortNames.ListShortNamesMethod(names);

            ShortNames.ListShortNamesQuery(names);
            #endregion

            #region Random Numbers
            List<int> numbers = RandomNumbers.CreateNumbers();

            RandomNumbers.ListNumbers(numbers);

            RandomNumbers.ListNumbersMethod(numbers);
            #endregion

            Utility.TerminateConsole();
        }
    }
}

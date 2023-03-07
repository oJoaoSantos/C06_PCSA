using D00_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Linq
{
    internal class RandomNumbers
    {
        public static List<int> CreateNumbers()
        {
            Random random = new Random();

            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(0, 50));
            }
            return numbers;
        }

        public static void ListNumbers(List<int> numbers)
        {

            Utility.BlockSeparator(2);
            Utility.WriteTitle("List Numbers");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void ListNumbersMethod(List<int> numbers)
        {
            var filteredNumbers = numbers.Where(number => number >= 10);
            Utility.BlockSeparator(2);
            Utility.WriteTitle("Random Numbers >= 10 Method Sintax");

            foreach (var item in filteredNumbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}


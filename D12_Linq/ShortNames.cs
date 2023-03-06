using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;

namespace D12_Linq
{
    internal class ShortNames
    {
        public static List<string> CreateNames()
        {
            List<string> Names = new List<string>()
            {
                "Joãoo",
                "Pedro",
                "Loureiro",
                "Santos",
                "Érica",
                "Alexandra",
                "Teixeira",
                "Matilde",
                "Palmira",
                "António"
            };
            return Names;
        }

        public static void ListNames(List<string> names)
        {

            Utility.BlockSeparator(2);
            Utility.WriteTitle("List Names");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }

        public static int FindShortName(List<string> names)
        {
            List<int> lenghts = new List<int>();
            
            foreach (var item in names)
            {
                lenghts.Add(item.Length);
            }

            //foreach (var item in lenghts)
            //{
            //    Console.WriteLine(item);
            //}

            int minLenghtIndex = lenghts.Min();
            return minLenghtIndex;
        }

        public static void ListShortNames(List<string> names, int min)
        {
            Utility.BlockSeparator(2);
            Utility.WriteTitle("Short Names");
            var shortNames = names
                .Where(name => name.Length == min)
                .OrderBy(name => name);

            foreach (var item in shortNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}

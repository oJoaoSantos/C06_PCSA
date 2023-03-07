using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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

        public static void ListShortNamesMethod(List<string> names)
        {
            List<string> filteredNames = names
                .Where(n => n.Length <= names.Min(x => x.Length)).ToList();
            Utility.BlockSeparator(2);
            Utility.WriteTitle("Short Names Method Sintax");

            foreach (var item in filteredNames)
            {
                Console.WriteLine(item);
            }
        }

        //v1

        //public static void ListShortNamesQuery(List<string> names)
        //{
        //    var filteredNames = from name in names
        //                        where name1.Length <= names.Min(name2 => name2.Length)
        //                        select name1;

        //    Utility.BlockSeparator(2);
        //    Utility.WriteTitle("Short Names Query Sintax");
        //    Console.WriteLine(names.Min());
        //    foreach (var item in filteredNames)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //v2
        public static void ListShortNamesQuery(List<string> names)
        {
            var filteredNames = from name1 in names
                                where name1.Length == (from name2 in names select name2.Length).Min()
                                select name1;

            Utility.BlockSeparator(2);
            Utility.WriteTitle("Short Names Query Sintax");
            Console.WriteLine(names.Min());
            foreach (var item in filteredNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Linq
{
    internal class HelloWorld
    {
        public void HelloWorldMethodSintax()
        {
            string[] words =
            {
                "t-sql",
                "hello",
                "wandreful",
                "linq",
                "beautiful",
                "world"
            };

            // filtrar os nomes com 5 caracteres, tranformar em Upper e listar.

            var filteredWords = words                                   
                .Where(word => word.Length == 5)
                .OrderByDescending(word => word)
                .Select(word => word.ToUpper());

            Utility.WriteTitle("Hello World Method Sintax");
            foreach (var word in filteredWords)
            { 
                Console.WriteLine(word);
            }
        }

        public void HelloWorldQuerySintax()
        {
            string[] words =
            {
                "t-sql",
                "hello",
                "wandreful",
                "linq",
                "beautiful",
                "world"
            };

            // filtrar os nomes com 5 caracteres, tranformar em Upper e listar.

            var filteredWords = from word in words              
                                where word.Length == 5
                                orderby word descending
                                select word.ToUpper();

            Utility.BlockSeparator(2);
            Utility.WriteTitle("Hello World Query Sintax");
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}

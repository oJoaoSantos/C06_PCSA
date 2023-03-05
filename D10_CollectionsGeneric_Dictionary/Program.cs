using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D10_CollectionsGeneric_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Dictionary -> criar e inserir os valores iniciais
            Dictionary<string, string> listCountries = new Dictionary<string, string>()
            {
                { "PT", "Portugal"},
                { "ES", "Espanha"},
                { "FR", "França"},
                { "IN", "Inglaterra"}
            };
            listCountries.Add("BR", "Brasil");
            #endregion

            #region Dictionary -> listar
            ListDictionary(listCountries);
            #endregion

            #region Dictionary -> inserir um paiís se não existir na lista
            // 1. Pesquisar
            string key = "AN";

            if (FindKey(listCountries, key))
            {
                // informa que existe
                Console.WriteLine("País Duplicado");
            }
            else
            {
                // insere o novo par
                InsertInDictionary(listCountries, key);
                Console.WriteLine("\n\n");
                ListDictionary(listCountries);
            }
            #endregion

            Utility.TerminateConsole();
        }

        // Boa prática é criar classes novas
        static void ListDictionary(Dictionary<string, string> list)
        {
            Utility.WriteTitle("Dictionary");
            foreach (KeyValuePair<string, string> item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        static bool FindKey(Dictionary<string, string> list, string key)
        {
            return list.ContainsKey(key);
        }

        static void InsertInDictionary(Dictionary<string, string> list, string key)
        {
            string newValue = $"{key}01"; // criar o novo Value
            list.Add(key, newValue);
        }
    }
}

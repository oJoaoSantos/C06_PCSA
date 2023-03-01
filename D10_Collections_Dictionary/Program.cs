using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D10_Collections_Dictionary
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

            #endregion

            #region Dictionary -> pesquisar uma chave

            #endregion

            Utility.TerminateConsole();
        }
    }
}

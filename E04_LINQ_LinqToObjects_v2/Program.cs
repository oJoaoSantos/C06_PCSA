using D00_Utility;
using E04_LINQ_LinkToObjects;
using E04_LINQ_LinqToObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_LINQ_LinqToObjects_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Creante and Show Lists
            List<City> cities = City.CreateCities();
            List<Client> clients = Client.CreateClients(cities);
            CityClient cityClient= new CityClient();
            City.ShowCities(cities);
            Client.ShowClients(clients);
            #endregion

            #region 2. Implementar com method e query syntax as seguintes consultas LINQ

            cityClient.e2_1(cities, clients);
            cityClient.e2_2(cities, clients);
            cityClient.e2_3(cities, clients);
            cityClient.e2_4(cities, clients);
            cityClient.e2_5(cities, clients);
            cityClient.e2_6(cities, clients);

            #endregion

            Utility.TerminateConsole();
        }
    }
}

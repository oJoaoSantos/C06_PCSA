using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E04_LINQ_LinkToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();


            #region Creante and Show Lists
            List<Client> clients = Client.CreateClients();
            List<City> cities = City.CreateCities();
            Client.ShowClients(clients);
            City.ShowCities(cities);
            #endregion

            #region 2. Implementar com method e query syntax as seguintes consultas LINQ

            #region 2.1. O nome dos clientes da cidade de Londres. 
            #region Sintax
            var filtered2_1 = clients
                .Where(client => client.CityName == "Londres")
                .Select(client => client.Name);

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.1. Results Sintax");
            foreach (var item in filtered2_1)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Query

            #endregion
            #endregion

            #region 2.2. O nome dos clientes da cidade de Lisboa ou de Madrid. 
            #region Sintax
            var filtered2_2 = clients
                .Where(client => client.CityName == "Lisboa" || client.CityName == "Madrid")
                .Select(client => client.Name);

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.2. Results Sintax");
            foreach (var item in filtered2_2)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Query

            #endregion
            #endregion

            #region 2.3.  Uma listagem com o formato "nome – idade" das pessoas com mais de 18 anos e ordenada pela idade, descendentemente.
            #region Sintax
            var filtered2_3 = clients.Where(client => client.Age > 18)
                .Select(client => client); // dúvida: pode concatenar-se logo no LINQ?

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.3. Results Sintax");
            foreach (var item in filtered2_3)
            {
                Console.WriteLine($"{item.Name} - {item.Age} ");
            }
            #endregion

            #region Query

            #endregion
            #endregion

            #region 2.4.  O nome dos clientes e o país de origem.
            #region Sintax

            #endregion

            #region Query
            var filtered2_4q = from client in clients
                               join citie in cities
                               on client.CityName equals citie.CityName
                               select new
                               {
                                   client.Name,
                                   citie.CountryName
                               };

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.4. Results Query");
            foreach (var item in filtered2_4q)
            {
                Console.WriteLine($"Name: {item.Name}\t Country: {item.CountryName}");
            }
            #endregion
            #endregion

            #region 2.5.  O número de clientes que mora em Londres. 
            #region Sintax
            var filtered2_5 = clients
                .Where(client => client.CityName == "Londres");

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.5. Results Sintax");
            Console.WriteLine(filtered2_5.Count());
            #endregion

            #region Query

            #endregion
            #endregion

            #region 2.6.  O cliente mais novo que mora em Londres.
            #region Sintax
            var filtered2_6 = clients                                               // otimizar
                .Where(client => client.CityName == "Londres");

            var filtered2_6_1 = filtered2_6
                .Where(client => client.Age == filtered2_6.Min(c => c.Age))
                .Select(client => client.Name);


            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.6. Results Sintax");
            foreach (var item in filtered2_6_1)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Query

            #endregion
            #endregion

            #endregion



            Utility.TerminateConsole();
        }
    }
}

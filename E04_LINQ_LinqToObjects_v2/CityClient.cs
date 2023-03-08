using D00_Utility;
using E04_LINQ_LinqToObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_LINQ_LinkToObjects
{
    internal class CityClient
    {
        #region 2.1. O nome dos clientes da cidade de Londres. 
        public void e2_1(List<City> cities, List<Client> clients)
        {
            #region Sintax
            var filtered2_1 = clients
                .Where(client => client.CityName == cities.FirstOrDefault(city => city.CityName == "Londres"))
                .Select(client => client.Name);

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.1. Results Sintax");
            foreach (var item in filtered2_1)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Query
            var filtered2_1q = from client in clients
                               where client.CityName == cities.FirstOrDefault(city => city.CityName == "Londres")
                               select client.Name;

            Utility.WriteTitle("2.1. Results Query");
            foreach (var item in filtered2_1q)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        #endregion

        #region 2.2. O nome dos clientes da cidade de Lisboa ou de Madrid. 
        public void e2_2(List<City> cities, List<Client> clients)
        {

            #region Sintax
            var filtered2_2 = clients
                .Where(client => client.CityName == cities.FirstOrDefault(city => city.CityName == "Lisboa") || client.CityName == cities.FirstOrDefault(city => city.CityName == "Madrid"))
                .Select(client => client.Name);

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.2. Results Sintax");
            foreach (var item in filtered2_2)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Query
            var filtered2_2q = from client in clients
                               where client.CityName == cities.FirstOrDefault(city => city.CityName == "Lisboa") || client.CityName == cities.FirstOrDefault(city => city.CityName == "Madrid")
                               select client.Name;

            Utility.WriteTitle("2.2. Results Query");
            foreach (var item in filtered2_2q)
            {
                Console.WriteLine(item);
            }
            #endregion
            }
        #endregion

        #region 2.3.  Uma listagem com o formato "nome – idade" das pessoas com mais de 18 anos e ordenada pela idade, descendentemente.
        public void e2_3(List<City> cities, List<Client> clients)
        {
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
            var filtered2_3q = from client in clients
                               where client.Age > 18
                               select client; // dúvida: pode concatenar-se logo no LINQ?

            Utility.WriteTitle("2.3. Results Query");
            foreach (var item in filtered2_3q)
            {
                Console.WriteLine($"{item.Name} - {item.Age} ");
            }
            #endregion
        }
        #endregion

        #region 2.4.  O nome dos clientes e o país de origem.
        public void e2_4(List<City> cities, List<Client> clients)
        {
            #region Sintax

            #endregion

            #region Query
            var filtered2_4q = from city in cities
                               join client in clients
                               on city.Id equals client.Id
                               select new
                               {
                                   client.Name,
                                   city.CountryName
                               };

            Utility.WriteTitle("2.4. Results Query");
            foreach (var item in filtered2_4q)
            {
                Console.WriteLine($"Name: {item.Name}\t Country: {item.CountryName}");
            }
            #endregion
        }
        #endregion

        #region 2.5.  O número de clientes que mora em Londres. 
        public void e2_5(List<City> cities, List<Client> clients)
        {
            #region Sintax
            var filtered2_5 = clients
                .Where(client => client.CityName == cities.FirstOrDefault(city => city.CityName == "Londres"));

            Utility.BlockSeparator(1);
            Utility.WriteTitle("2.5. Results Sintax");
            Console.WriteLine(filtered2_5.Count());
            #endregion

            #region Query
            var filtered2_5q = from client in clients
                               where client.CityName == cities.FirstOrDefault(city => city.CityName == "Londres")
                               select client;

            Utility.WriteTitle("2.5. Results Query");
            Console.WriteLine(filtered2_5q.Count());
            #endregion
        }
        #endregion

        #region 2.6.  O cliente mais novo que mora em Londres.
        public void e2_6(List<City> cities, List<Client> clients)
        {
            #region Sintax
            var filtered2_6 = clients                                               // otimizar
                .Where(client => client.CityName == cities.FirstOrDefault(city => city.CityName == "Londres"));

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
            var filtered2_6q = from client in clients                                               // otimizar
                               where client.CityName == cities.FirstOrDefault(city => city.CityName == "Londres")
                               select client;

            var filtered2_6_1q = from client in filtered2_6q
                                 where client.Age == filtered2_6.Min(c => c.Age)
                                 select client.Name;

            Utility.WriteTitle("2.6. Results Query");
            foreach (var item in filtered2_6_1q)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        #endregion

    }
}

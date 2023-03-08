using D00_Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace E04_LINQ_LinqToObjects
{
    internal class Client
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public City CityName { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        public static List<Client> CreateClients(List<City> cities)
        {
            List<Client> clients = new List<Client>();
            clients.Add(new Client { Id = 1, Name = "Amália", Age = 35, CityName = cities.FirstOrDefault(city => city.CityName == "Porto") });
            clients.Add(new Client { Id = 2, Name = "John", Age = 35, CityName = cities.FirstOrDefault(city => city.CityName == "Londres") });
            clients.Add(new Client { Id = 3, Name = "Charles", Age = 53, CityName = cities.FirstOrDefault(city => city.CityName == "Londres") });
            clients.Add(new Client { Id = 4, Name = "Lucy", Age = 21, CityName = cities.FirstOrDefault(city => city.CityName == "Paris") });
            clients.Add(new Client { Id = 5, Name = "Javi", Age = 14, CityName = cities.FirstOrDefault(city => city.CityName == "Madrid") });

            return clients;
        }

        public static void ShowClients(List<Client> clients)
        {
            Utility.WriteTitle("Clients");

            foreach (Client item in clients)
            {
                Console.WriteLine($"Name: {item.Name}\t City: {item.CityName.CityName}\t Age: {item.Age}");
            }
        }
        #endregion
    }
}

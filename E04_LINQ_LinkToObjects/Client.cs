using D00_Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace E04_LINQ_LinkToObjects
{
    internal class Client
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string CityName { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        public static List<Client> CreateClients()
        {
            List<Client> clients = new List<Client>();
            clients.Add(new Client { Name = "Amália", Age = 35, CityName = "Porto" });
            clients.Add(new Client { Name = "John", Age = 35, CityName = "Londres" });
            clients.Add(new Client { Name = "Charles", Age = 53, CityName = "Londres" });
            clients.Add(new Client { Name = "Lucy", Age = 21, CityName = "Paris" });
            clients.Add(new Client { Name = "Javi", Age = 14, CityName = "Madrid" });

            return clients;
        }

        public static void ShowClients(List<Client> clients)
        {
            Utility.WriteTitle("Clients");

            foreach (Client item in clients)
            {
                Console.WriteLine($"Name: {item.Name}\t City: {item.CityName}\t Age: {item.Age}");
            }
        }
        #endregion
    }
}

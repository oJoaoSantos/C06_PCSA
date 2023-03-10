using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E04_Linq_LinqToObjects
{

    public static class CityCustomer
    {

        #region Cities and Customers     
        public static List<City> CreateCities(List<City> listCities)
        {

            // Table 1
            listCities.Add(new City { Location = "Porto", Country = "Portugal" });
            listCities.Add(new City { Location = "Londres", Country = "Inglatera" });
            listCities.Add(new City { Location = "Paris", Country = "França" });
            listCities.Add(new City { Location = "Madrid", Country = "Espanha" });

            return listCities;

        }

        public static List<Customer> CreateCustomers(List<Customer> listCustomers, List<City> listCities)
        {

            // Table n
            listCustomers.Add(new Customer { Name = "Amália", Location = listCities.FirstOrDefault(c => c.Location == "Porto"), Age = 35 });
            listCustomers.Add(new Customer { Name = "John", Location = listCities.FirstOrDefault(c => c.Location == "Londres"), Age = 35 });
            listCustomers.Add(new Customer { Name = "Charles", Location = listCities.FirstOrDefault(c => c.Location == "Londres"), Age = 53 });
            listCustomers.Add(new Customer { Name = "Lucy", Location = listCities.FirstOrDefault(c => c.Location == "Paris"), Age = 21 });
            listCustomers.Add(new Customer { Name = "Javi", Location = listCities.FirstOrDefault(c => c.Location == "Madrid"), Age = 14 });

            return listCustomers;

        }
        #endregion

        #region List
        public static void ListData(IEnumerable listFiltered, string title, string separator = "\n\n")
        {

            Utility.BlockSeparator(separator);
            Utility.WriteTitle(title);

            foreach (var item in listFiltered)
            {
                Console.WriteLine($"\t{item}\t");
            }

        }
        #endregion

        #region Answers - method syntax
        // 1. Nome dos clientes de Londres
        public static IEnumerable CitiesCustomersMethodSyntaxQuestion1(List<Customer> listCustomers)
        {

            return listCustomers.Where(c => c.Location.Location == "Londres").Select(c => c.Name).ToList();

        }

        // 2. Nome dos clientes de Lisboa ou Madrid
        public static IEnumerable CitiesCustomersMethodSyntaxQuestion2(List<Customer> listCustomers)
        {

            return listCustomers.Where(c => c.Location.Location == "Lisboa" || c.Location.Location == "Madrid").Select(c => c.Name).ToList();

        }

        // 3. Pessoas com mais de 18 anos, ordenadas descendentemente pela idade (nome - idade)
        public static IEnumerable CitiesCustomersMethodSyntaxQuestion3(List<Customer> listCustomers)
        {

            return listCustomers
                .Where(c => c.Age > 18)
                .OrderByDescending(c => c.Age)
                .Select(c => $"{c.Name} - {c.Age}")
                .ToList();

        }

        // 4. Nome dos clientes e país de origem
        public static IEnumerable CitiesCustomersMethodSyntaxQuestion4(List<Customer> listCustomers)
        {

            return listCustomers.Select(c => $"{c.Name}, {c.Location.Country}").ToList();

        }

        // 5. Número de clientes que moram em Londres
        public static void CitiesCustomersMethodSyntaxQuestion5(List<Customer> listCustomers)
        {

            Utility.BlockSeparator("\n\n");
            Utility.WriteTitle("5. Número de clientes que moram em Londres");

            int listFilteredCount = listCustomers.Where(c => c.Location.Location == "Londres").Count();

            // Não posso usar o método para listar
            Utility.WriteMessage($"\t{listFilteredCount}");

        }

        // 6. Cliente mais novo de Londres
        public static IEnumerable CitiesCustomersMethodSyntaxQuestion6(List<Customer> listCustomers)
        {

            return listCustomers
                .Where(c => c.Location.Location == "Londres")
                .OrderBy(c => c.Age)
                .Take(1)    //.FirstOrDefault();        // Top
                .Select(s => s.Name)
                .ToList(); 

        }
        #endregion

    }

}

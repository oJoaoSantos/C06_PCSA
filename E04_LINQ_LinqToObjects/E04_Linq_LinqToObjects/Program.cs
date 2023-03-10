using D00_Utility;
using System.Collections;
using System.Collections.Generic;

namespace E04_Linq_LinqToObjects
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Data
            List<City> listCities = new List<City>();
            List<Customer> listCustomers = new List<Customer>();
            IEnumerable listFiltered;

            listCities = CityCustomer.CreateCities(listCities);
            listCustomers = CityCustomer.CreateCustomers(listCustomers, listCities);
            #endregion

            #region Answers - method syntax            
            listFiltered = CityCustomer.CitiesCustomersMethodSyntaxQuestion1(listCustomers);
            CityCustomer.ListData(listFiltered, "1. Nome dos clientes de Londres", "");

            listFiltered = CityCustomer.CitiesCustomersMethodSyntaxQuestion2(listCustomers);
            CityCustomer.ListData(listFiltered, "2. Nome dos clientes de Lisboa ou Madrid");

            listFiltered = CityCustomer.CitiesCustomersMethodSyntaxQuestion3(listCustomers);
            CityCustomer.ListData(listFiltered, "3. Pessoas com mais de 18 anos (desc idade)");

            listFiltered = CityCustomer.CitiesCustomersMethodSyntaxQuestion4(listCustomers);
            CityCustomer.ListData(listFiltered, "4. Nome dos clientes e país de origem");

            CityCustomer.CitiesCustomersMethodSyntaxQuestion5(listCustomers);

            listFiltered = CityCustomer.CitiesCustomersMethodSyntaxQuestion6(listCustomers);
            CityCustomer.ListData(listFiltered, "6. Cliente mais novo de Londres");
            #endregion

            Utility.TerminateConsole();

        }

    }

}

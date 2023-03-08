using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E04_LINQ_LinqToObjects
{
    internal class City
    {
        #region Properties
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        public static List<City> CreateCities()
        {
            List<City> cities = new List<City>();
            cities.Add(new City { Id = 1, CityName = "Porto", CountryName = "Portugal" });
            cities.Add(new City { Id = 2, CityName = "Londres", CountryName = "Inglaterra" });
            cities.Add(new City { Id = 3, CityName = "Paris", CountryName = "França" });
            cities.Add(new City { Id = 4, CityName = "Madrid", CountryName = "Espanha" });

            return cities;
        }

        public static void ShowCities(List<City> cities)
        {
            Utility.WriteTitle("Cities");

            foreach (City item in cities)
            {
                Console.WriteLine($"City: {item.CityName}\t Country: {item.CountryName} ");
            }
        }
        #endregion
    }
}

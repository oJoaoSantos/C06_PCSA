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
        public string CityName { get; set; }
        public string CountryName { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        public static List<City> CreateCities()
        {
            List<City> cities = new List<City>();
            cities.Add(new City { CityName = "Porto", CountryName = "Portugal" });
            cities.Add(new City { CityName = "Londres", CountryName = "Inglaterra" });
            cities.Add(new City { CityName = "Paris", CountryName = "França" });
            cities.Add(new City { CityName = "Madrid", CountryName = "Espanha" });

            return cities;
        }

        public static void ShowCities(List<City> cities)
        {
            Utility.BlockSeparator(2);
            Utility.WriteTitle("Cities");

            foreach (City item in cities)
            {
                Console.WriteLine($"City: {item.CityName}\t Country: {item.CountryName} ");
            }
        }
        #endregion
    }
}

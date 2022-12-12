using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllByPopulation.Entities
{
    internal class Country
    {
        public string Name;
        List<City> Cities;
        int count;

        public Country(string name) { Name = name; Cities = new List<City>(); Console.WriteLine($"Country: {name}\n") ; }

        public void AddCity(City city) { Cities.Add(city); }

        public void TotalPopulation()
        {
            for(int i = 0; i<Cities.Count; i++)
            {
                City city = Cities[i];
                count+=city.Population;
            }
                Console.WriteLine($"Total population: {count} people.");
        }

        public void  FindAllByPopulation(int min, int max)
        {
            Console.WriteLine($"Cities in interval {min}-{max}: \n");

            for (int i = 0; i < Cities.Count; i++)
            {
                City city = Cities[i];
                if (city.Population >= min && city.Population <= max)
                {
                    Console.WriteLine("- "+city.Name);
                }
            }
            Console.WriteLine(" ");
        }

    }
}

using FindAllByPopulation.Entities;

namespace FindAllByPopulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City("Baku", 6000);
            City city1= new City("Gence", 2000);

            Country country = new Country("Azerbaijan");
            country.AddCity(city);
            country.AddCity(city1);

            country.FindAllByPopulation(1000, 8000);
            country.TotalPopulation();
        }
    }
}
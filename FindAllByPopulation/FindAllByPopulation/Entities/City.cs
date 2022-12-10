using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllByPopulation.Entities
{
    internal class City
    {
        public string Name;
        public int Population;
    
        public City(string name, int population) { Name = name; Population = population; }
    }
}

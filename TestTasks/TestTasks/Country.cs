using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
   public class Country
    {
        public string name { get; set; }
        public int population { get; set; }
        public Country(string _name, int _population)
        {
            name = _name;
            population = _population;
        }

        public override string ToString()
        {
            return $"{name} | {population}";
        }
    }
}

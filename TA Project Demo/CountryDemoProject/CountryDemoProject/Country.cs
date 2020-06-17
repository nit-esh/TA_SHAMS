using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDemoProject
{
    class Country
    {
        public string Name { get; }
        public string Code { get; }
        public string Continent { get;}
        public int Population { get; }

        //Propetirs
        //Methods
        //Fields
        //Events
        public Country(string name, string code, string continent, int population)
        {
            Name = name;
            Code = code;
            Continent = continent;
            Population = population;
        }
       

    }
}

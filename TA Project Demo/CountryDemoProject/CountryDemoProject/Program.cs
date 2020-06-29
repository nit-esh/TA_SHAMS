using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "F:\\Countries_Population_Largest.csv";

            CsvReader csvReader = new CsvReader(filePath);

            //Console.Write("Enter the number of countries : >");
            //int nCountries = int.Parse(Console.ReadLine());
            //Console.WriteLine($" ****** List of {nCountries} countries in decreasing order of population ****** ");
            //Country[] countries = csvReader.ReadNCountries(nCountries);

            List<Country> countries = csvReader.ReadAllCountries();

            foreach (Country country in countries)
            {
                Console.WriteLine($"Country : {country.Name.PadRight(20)} Code : {country.Code.PadRight(8)} Continent: {country.Continent.PadRight(15)} Population :{country.Population}");
            }
            Console.WriteLine();

            
        }
    }
}

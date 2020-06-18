using System;
using System.IO;

namespace CountryDemoProject
{
    class SingleOperationClassNew
    {

        static void Main(string[] args)
        {

            string filePath = "G:\\countries.txt";

            StreamReader sr = new StreamReader(filePath);
            //sr.ReadLine();
            Console.WriteLine("Enter the number of countries to be displayed: >");
            var nCountries = int.Parse(Console.ReadLine());  
            for (int i = 1; i <= nCountries; i++)
            {
                var csvline=sr.ReadLine();
                string[] parts= csvline.Split(',');

                string name = parts[0];
                string code = parts[1];
                string continent = parts[2];
                int population = int.Parse(parts[3]);
                //int density = int.Parse(parts[4]);

                Console.WriteLine($"Country: {name}, Code: {code}, Continent: {continent}, Population : {population}");
            }
;        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDemoProject
{
    
    /// <summary>
    /// CSV reader class for CSV file operation
    /// </summary>
    class CsvReader
    {
        /// <summary>
        /// Property to store the file path of the CSV file
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// Constructor to store the file path value in the FilePath property .
        /// </summary>
        /// <param name="csvFilePath"></param>
        public CsvReader(string csvFilePath)
        {
            FilePath = csvFilePath;
        }

        /// <summary>
        /// Reading the countries' data from the CSV file line-by-line
        /// </summary>
        /// <param name="nCountries"></param>
        /// <returns></returns>
        public Country[] ReadNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];

            using (StreamReader sr = new StreamReader(FilePath))
            {

                sr.ReadLine(); //read the header line

                for (int i = 0; i < nCountries; i++)
                {
                    var csvline = sr.ReadLine();
                    countries[i] = ReadSeperateData(csvline);

                }
                return countries;
            };
        }

        /// <summary>
        /// Sepaerating the line -by-line and storing it into an array.
        /// </summary>
        /// <param name="csvline"></param>
        /// <returns></returns>
        private Country ReadSeperateData(string csvline)
        {
            string[] parts = csvline.Split(',');
            int size=parts.Length;
            int count;
            switch (size)
            {
                
                case 4:

                    string name = parts[0];
                    string code = parts[1];
                    string continent = parts[2];
            //string population = int.Parse(parts[3]);
                    int.TryParse(parts[3], out count);//return 0 if not able to parse
                    return new Country(name, code, continent, count);

                case 5:
                    name = parts[0] +"," +parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    continent = parts[3];
                    int.TryParse(parts[4], out count);
                    return new Country(name, code, continent, count);

                default:
                    return null;


            }
            


        }


        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(FilePath))
            {
                // read header line
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadSeperateData(csvLine));
                }
            }

            return countries;
        }
    }
}

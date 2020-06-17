using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDemoProject
{
    class CsvReader
    {
        public string FilePath { get; }

        public CsvReader(string csvFilePath)
        {
            FilePath = csvFilePath;
        }

        public Country[] ReadNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            using (StreamReader sr = new StreamReader(FilePath))
            {
                
                sr.ReadLine(); //read the header line
                
                for (int i = 0; i < nCountries; i++)
                {
                    var csvline = sr.ReadLine();
                    countries[i] = CsvReader.ReadSeperateData(csvline);
                    
                }
                return countries;
            };
           
            
            
        }

        private static Country ReadSeperateData(string csvline)
        {
           
            string[] parts = csvline.Split(new char[] { ',' });
            
            return new Country(parts[0], parts[1], parts[2], int.Parse(parts[3]));

        }
    }
}

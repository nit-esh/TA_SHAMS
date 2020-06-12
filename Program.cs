using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();

            //Add the grades in the book
            book.AddGrade(58.3);
            book.AddGrade(60.8);
            book.AddGrade(98.2);

            //Display the grades of a book
            book.DisplayGrade();

            //Shows the Highest, Lowest and Average grades of a class
            book.ShowStatistics();

        }



           
        
    }
}

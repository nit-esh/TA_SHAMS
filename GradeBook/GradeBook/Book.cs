using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Book
    {
       public Book()
        {
            grades = new List<double>();
            //Console.WriteLine("An Object is created");
        }

       public  void AddGrade(double grade)
        {
            grades.Add(grade);
        }

       public void DisplayGrade()
        {
            Console.WriteLine("The grades are :");
            foreach (var grade in grades)
            {
                
                Console.WriteLine(grade);
            }
        }

       public void ShowStatistics()
        {
            var highestGrade = double.MinValue;

            foreach (var grade in grades)
            {
                highestGrade = Math.Max(highestGrade, grade);

            }
            Console.WriteLine("The highest Grade is :{0}",highestGrade);

            var lowestGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowestGrade = Math.Min(lowestGrade, grade);

            }
            Console.WriteLine("The lowest grade is :{0}",lowestGrade);

            double sum = 0;
            var gradeCount = grades.Count;
            foreach (var grade in grades)
            {
                sum = sum + grade;
            }
            var average = sum / gradeCount;

            Console.WriteLine("The average grade is :{0}", average);
        }

        List<double> grades;
    }
}

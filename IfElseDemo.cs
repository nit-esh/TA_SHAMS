using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementDemoProject
{
    class IfElseDemo
    {
        static void Main(string[] args)
        {
            // We use if-else to excecute blocks of code which satisfy certain conditions.

            double marks=0;

            #region While Loop Example
            while(true)
            {
                Console.WriteLine("Enter the marks : ");
                string value = Console.ReadLine();

                marks = double.Parse(value);

                if (marks <= 35)
                {
                    Console.WriteLine("Better Luck next time !");
                    Console.WriteLine("Work hard....");
                }

                else
                {
                    Console.WriteLine("Congratulations !");
                    Console.WriteLine("You are promoted.\n");
                }

                Console.WriteLine("Want to enter more marks ? y/n ");
                string check = Console.ReadLine();
                if (check == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            #endregion

            #region For-loop example
            //for (; ; )
            //{
            //    Console.WriteLine("Enter the marks : ");
            //    string value = Console.ReadLine();

            //    marks = double.Parse(value);

            //    if (marks <= 35)
            //    {
            //        Console.WriteLine("Better Luck next time !");
            //        Console.WriteLine("Work hard....");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Congratulations !");
            //        Console.WriteLine("You are promoted.\n");
            //    }

            //    Console.WriteLine("Want to enter more marks ? y/n ");
            //    string check = Console.ReadLine();
            //    if (check == "y")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Are you sure? y/n");
            //        string checkAgain=Console.ReadLine();
            //        if (checkAgain=="n")
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
                
               
            //}

            #endregion

        }
    }
}

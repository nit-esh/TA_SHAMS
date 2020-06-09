using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementDemoProject
{
    public class SwitchCaseDemo
    {
        static void Main(string[] args)
        {
            #region Switch-Case Demo
            //while (true)
            //{
            //    int dayOfWeek;
            //    Console.WriteLine("Enter the day number: ");
            //    dayOfWeek = int.Parse(Console.ReadLine());

            //    switch (dayOfWeek)
            //    {
            //        case 1:
            //            Console.WriteLine("It is Sunday !");
            //            goto case 1; 

            //        case 2:
            //            Console.WriteLine("It is Monday !");
            //            goto case 3;
                        
            //        case 3:
            //            Console.WriteLine("It is Tuesday !");
            //            goto case 4;
                       
            //        case 4:
            //            Console.WriteLine("It is Wednesday !");
            //            goto case 5;
                        
            //        case 5:
            //            Console.WriteLine("It is Thursday !");
            //            break;
                        
            //        case 6:
            //            Console.WriteLine("It is Friday !");
            //            break;
            //        case 7:
            //            Console.WriteLine("It is Saturday !");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid day number. Kindly enter the number between 1-7");
            //            break;

            //    }

                
            //    Console.WriteLine("Do you want to enter another number?y/n");

            //    string check = Console.ReadLine();
            //    if (check=="y")
            //    {
            //        continue;
                    
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            #endregion

            var num = 5;
            while(num<=50)
            {
                Console.WriteLine(num) ;
                num += 5;

            }
        }
    }
}

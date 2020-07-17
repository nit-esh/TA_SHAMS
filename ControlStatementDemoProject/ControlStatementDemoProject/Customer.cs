using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementDemoProject
{
    public class Customer
    {
        //fields
        public static string firstname { get; set; }
        //properties

        //methods

        //events
    }
    


    class Program
    {
        public static void Main(string[] args)
        {
            Customer.firstname = "Nitesh";
            Customer customer = new Customer();
           

            Customer customer_new = new Customer();
            customer_new = customer;

           

            Console.WriteLine(Customer.firstname);

            int i = 5;
            int j = i;
            j = 10;
            Console.WriteLine(i); ;


            

        }
    }
    
}

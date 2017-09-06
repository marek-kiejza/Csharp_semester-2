using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            double total = 0, cost = 0;
            int numHour ;


            for (;;)
            {
                Console.WriteLine("Enter number of hours (-999 to quit) :");
                numHour = int.Parse(Console.ReadLine());
                if (numHour == -999)
                    break;
                else
                {
                    cost = Add(numHour);
                    Console.WriteLine("Customer Charge : {0}",cost);
       
                }
                total += cost;
                Console.WriteLine("Total Receipt{0}", total);
            }
        }

        static double Add(double num1)
        {
           double cost =0;
            if (num1 > 3)
            {
                cost = 6 + (num1 - 3 * .5);
            }
            else
                cost += num1;

            if (cost >= 10)
                cost = 10;
           
            return cost;
        }
    }
}

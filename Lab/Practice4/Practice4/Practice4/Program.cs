using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Paddy";
            int age = 12;
            string town = "SLigo";
            double radius = 15;

            double rectangle = 20;

            Greeting(name, age ,town);

            double result = ircleArea(radius);
            Greeting("Radius ", result , "Area");

            double result2 = Triangle(rectangle, 5);
            Greeting("Rectangle", rectangle, "Lenght");

            Console.ReadLine();
        }
        static void Greeting(string name, double age , string town)
        {
            Console.WriteLine(" {0} , {1} ,{2}", name, age ,town);

        }

        static double ircleArea(double radius)
            {
            double arena;

            arena = Math.PI * Math.Pow(radius, 2);
            return arena;
            }
        static double Triangle(double l,double n)
        {

            double reeturn = l * n;

                return reeturn;
        }
        
    }
}

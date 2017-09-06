using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = k(2);
            Console.WriteLine(x1);
            double x2 = h(2);
            Console.WriteLine(x2);
            double x3 = g(2) + h(2);
            Console.WriteLine(x3);

            double x4 = f(2);
            Console.WriteLine(x4);

            Console.ReadLine();
        }

        static double f(double x) { return g(x) + Math.Sqrt(h(x)); }
        static double g(double x) { return 4 * h(x); }
        static double h(double x) { return x * x + k(x) - 1; }
        static double k(double x)
        {
            return 2 * (x + 1);
        }
    }
}

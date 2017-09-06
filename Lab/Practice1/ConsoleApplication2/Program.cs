using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop");
            for (int x = 1; x <= 20; x += 1)
            {
                if (x == 6) continue;
                if (x == 8) continue;
                Console.WriteLine(x);
            }
            
            Console.ReadKey();
        }
    }
}

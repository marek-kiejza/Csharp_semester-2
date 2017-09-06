using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 5; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


                for (int y = 0; y <= 5; y++)
                 { 
                    for (int t = 5; t  >y; t--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                     }

            Console.ReadLine();
        }
    }
}

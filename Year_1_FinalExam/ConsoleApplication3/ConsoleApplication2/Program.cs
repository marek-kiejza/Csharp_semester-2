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
            int[,] squareWeights = new int[3, 3]
            {
                {1,0,1},
                {0,2,0},
                {1,0,1}
            };
            for (int i = 0; i < 3; i++)
            {


                for (int j = 0; j < 3; j++)
                {
                    Console.Write(squareWeights[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

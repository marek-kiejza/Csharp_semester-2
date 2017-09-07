using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {


        static int[] playerAges = new int[6];//Q1
        static int[] playerAges2 = new int[6];//Q1
        static int[] numberRev = { 7, 3, 5, 9, 2, 8 };//Q8
        static int[] numTemp = { 0, 0, 0, 0, 0, 0 };
        static int[] numMult = { 5, 7, 6, 5, 4, 3 };

        static void Main(string[] args)
        {
            double average;

            //ReadRev();//Q8
            //Console.WriteLine();
            //Revers();//Q8
            //ReadRev();//Q8
            GetAges();
            //PrintAge();
            //Multi();
            //Console.WriteLine();
            //int total = Multi();
            //Console.WriteLine(total);
            //// SecendAge();
            ////ReversAge();
            //average= AverageAge();
            // Console.WriteLine(average);
            // Serch();
            Console.ReadLine();
        }




        static void GetAges() // Q2
        {
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write("Enter age {0}: ", i + 1);
                playerAges[1] = 9;//int.Parse(Console.ReadLine());
                Console.WriteLine(playerAges[1]);
            //}

        }
        static int Multi()
        {
            int total = 0;
            for (int i = 0; i < playerAges.Length; i++)
            {
                playerAges2[i] = playerAges[i] * numMult[i];
                total += playerAges2[i];
            }
            return total;
        }
        static void PrintAge()// Q3
        {
            int i = 1;
            foreach (int item in playerAges)
            {
                Console.WriteLine("Plaer {0} age is {1}", i, item);
                i++;
            }
        }

        static void SecendAge()// Q4
        {

            Console.WriteLine("Player 1 age {0}", playerAges[0]);
            Console.WriteLine("Player 3 age {0}", playerAges[2]);
            Console.WriteLine("Player 6 age {0}", playerAges[5]);

        }

        static void ReversAge()// Q5
        {

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("Plaer {0} age is {1}", i + 1, playerAges[i]);

            }
        }

        static double AverageAge()// Q6
        {
            int total = 0;
            double avr;
            for (int i = 0; i < playerAges.Length; i++)
            {
                total += playerAges[i];
            }
            avr = (double)total / playerAges.Length;

            return avr;

        }

        static void Serch()//Q7
        {
            bool sarch = false;

            Console.WriteLine("Serch for age:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < playerAges.Length; i++)
            {
                if (num == playerAges[i])
                {
                    sarch = true;
                }

            }
            Console.WriteLine(sarch);
        }
        static void ReadRev()//Q8
        {
            for (int i = 0; i < numberRev.Length; i++)
            {
                Console.WriteLine(numberRev[i]);
            }


        }
        static void Revers()//Q8
        {
            int y = 5;
            for (int i = 0; i < numberRev.Length; i++)
            {

                numTemp[y] = numberRev[i];

                y--;
            }
            for (int i = 0; i < numberRev.Length; i++)
            {
                numberRev[i] = numTemp[i];
            }

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0,b=0;

            a=ReadInt();
            b = ReadInt();
            Console.WriteLine(Multi(a));
            Console.WriteLine(Multi(b));

            Console.ReadLine();
        }

        static private int ReadInt()
        {
            bool check = false;
            int result = 0;
            string inputValue;
            while (check == false)
            {
                inputValue = Console.ReadLine();
                check = int.TryParse(inputValue, out result);

                if (check == false)
                    Console.WriteLine("Invalid input");
            }
            return result;
        }

        static int Multi(int z)
        {
            z= z * 2;
            return z;

        }
    }
}

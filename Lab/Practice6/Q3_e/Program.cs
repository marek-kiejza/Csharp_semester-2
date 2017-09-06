using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;


            x = ReadInt();

            y = ReadInt();

            z = ReadInt();

            bool small = Smallest(x, y, z);

            Console.WriteLine(small);

            Console.ReadLine();
        }

        static bool Smallest(int x, int y, int z)
        {
            bool small = false;

            if (x < y)
                if (y < z)
                    small = true;

                else
                    small = false;

            return small;
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
    }

}

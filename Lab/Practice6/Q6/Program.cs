using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = ReadInt("Please enter your salery : ");
            Console.WriteLine("Your selery is {0}",salary);
            Console.ReadLine();
        }
        static private int ReadInt(string prompt)
        {
            Console.Write(prompt);

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

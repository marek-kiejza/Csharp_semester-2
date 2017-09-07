using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                string ageString = Console.ReadLine();
                age = int.Parse(ageString);
                Console.WriteLine("Thank you");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


        }
    }
}

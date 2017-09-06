using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mareks_stuff
{
    static public class Class1
    {

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

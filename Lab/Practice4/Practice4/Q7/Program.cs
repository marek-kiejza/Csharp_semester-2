using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken , kok =0;

            chicken=Read(kok);

            bool check = Ifcheck(chicken);

            Answer(check);

            Console.ReadLine();

        }

        static int Read (int chik)
        {
            chik = int.Parse(Console.ReadLine());

            return chik;
        }
        static bool Ifcheck(int chick)
        {
            bool result;
            if (chick == 6 || chick == 9 || chick == 12)
                result = true;
            else
                result = false;

            return result;

        }

        static void Answer(bool check)
        {
            if(check==true)
            Console.WriteLine("OK");

            else
                Console.WriteLine("invalid quantity");
        }
    }
}

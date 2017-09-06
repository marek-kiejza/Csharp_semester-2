using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0, num2=0;

            ReadInt(ref num1);
            ReadInt(ref num2);
            Calc(num1, num2);
            Console.ReadLine();
        }

        static private int ReadInt(ref int num)
        {
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());

            return num;
        }

        static private void Calc(int num1 , int num2)
        {
            int i = 0;
            int num3=0,num4=0;
            if (num1 > num2)
            {
                num3 = num1;
                num1 = num2;
                num2 = num3;
            }
            

            for ( i = num1; i <= num2; i++)
            {
               
                num4 += i;
                
            }
            Console.WriteLine(num4);
        }
    }
}

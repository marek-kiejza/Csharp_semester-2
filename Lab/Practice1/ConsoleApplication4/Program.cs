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
            int n1, n2,sum=0;
            Console.Write("Enter first number:");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter secend number:");
            n2 = int.Parse(Console.ReadLine());
            for (;n1<n2; n1 += 2)
            {
                    if (sum >= 500)
                    {
                    break;
                    }
                    else
                    {
                        if (n1 % 2 == 1)

                            sum += n1;

                        else
                            n1++;

                    
                    }
                    
            }
            if (sum >= 500)
                Console.WriteLine("sum too large");
            else
                Console.WriteLine(sum);
            

             
        }
    }
}

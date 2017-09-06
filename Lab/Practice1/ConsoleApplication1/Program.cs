using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop" );
            for(int x=1;x<=20;x+=1)
            {
          
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("While loop");
            int y = 0;
            while(y<20)
            {
                y++;
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}

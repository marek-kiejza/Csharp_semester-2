using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            double balance = 1000, saving = 100,incrise=0 ;

            Console.WriteLine("test with initial balance = {0}, years = 2; monthly saving = {1}",balance,incrise);
            for(int x=1;x<=24;x++)
            {
                incrise = (balance / saving);

                balance += 100;

                balance += incrise;

            
            }
            Console.WriteLine(balance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string eproduct;
            int quantity;
            int total;

         
            Console.Write("Enter product:");
            eproduct = Console.ReadLine();


            int eprice = GetPrice(eproduct);//GetPrice is a method , product is name of switch


            Console.WriteLine("Enter quantity");
            quantity = int.Parse(Console.ReadLine());
            total = eprice * quantity;
            
            Console.WriteLine("Product price is: {0}",total);



            
        }

        static int GetPrice(string product)
        {
            int price;
            switch (product.ToUpper())
            {
                case "A":
                    price = 100;
                    break;

                case "B":
                    price = 200;
                    break;

                case "C":
                case "D":
                    price = 300;
                    break;

                case "E":
                    price = 400;
                    break;

                default:
                    price = 0;
                    break;
            }
            return price;

        }
    }
}

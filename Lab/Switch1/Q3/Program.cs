using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score= 0;

            Console.WriteLine("Insert the score");
            score = int.Parse(Console.ReadLine());
            score = score / 10;

            string message= result(score);

            Console.WriteLine(message);
            
        }


      static  string result(int score)
        {
            string  message;

            switch (score)
            {
                case 10:
                case 9:
                case 8:
                    message="Awesome dude";
                break;

                case 7:
                    message="Your good dude";
                    break;

                case 6:
                    message="some potential here dude";
                    break;

                case 5:
                    message ="back to the training ground dude";
                    break;

                default:
                    message="don’t give up the day job dude";
                    break;

                    

            }
            return message;

        } 
    }
}

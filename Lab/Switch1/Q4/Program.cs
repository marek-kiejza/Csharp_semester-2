using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardValue,cardName,cardType,card;


            Console.WriteLine("Chose Your card");
            cardValue = Console.ReadLine();


            switch(cardValue)
            {
                case "A":
                    cardValue = "Ace";
                    break;
                case "B":
                    cardValue = "Ace";
                    break;
                case "J":
                    cardValue = "Jack";
                    break;
                case "Q":
                    cardValue = "Queen";
                    break;
                case "K":
                    cardValue = "King";
                    break;

            }

        }
    }
}

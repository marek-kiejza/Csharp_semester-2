using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// must include this reference when implementing file handling


/*

Marek Kieja
S00173510
14/04/2017
Program for a games company maintains high score records for its game players.  

    */
class Game
{
    static void Main()
    {
        //QI
        /*
        string text,revers;

         text = Console.ReadLine();
         revers = Reverse(text);
         Console.WriteLine(revers);
         Console.ReadKey();
         */

        //QII
        /*
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int days=0,price=0;
        Console.Write("How many days You whont to rent the car?");
        days = Try(days);
        price=CarRent(days);
        Console.WriteLine("Rental charge is €{0}", price);
        Console.ReadKey();
        */

        //QIII
        /*
        bool sort=false;

        int x=0,y=0,z=0;

        Console.Write("Type int 1: ");
        x=Try(x);
        Console.Write("Type int 2: ");
        y = Try(y);
        Console.Write("Type int 3: ");
        z = Try(z);

        Console.WriteLine("int 1={0},int2={1},int3={2}",x,y,z);
        Console.WriteLine("Sort={0}",sort);
        Console.WriteLine("Press enter to sort");
        Console.ReadKey();
        Console.WriteLine();
        sort = Sorted(ref x, ref y, ref z);

        Console.WriteLine("int 1={0}, int2={1}, int3={2}", x, y, z);
        Console.WriteLine("Sort={0}", sort);


        Console.WriteLine(sort);
        Console.ReadKey();
        */

        //QIV
        /*
        int days=0,discount;


        Console.Write("Enter number of holidays days: ");
        days = Try(days);
        discount = Discount(days);
        Console.WriteLine("Yor discount is :{0}%",discount);
        Console.ReadKey();
        */

        //QV
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int balance = 0, withdrow = 0, newbalance;
        Console.Write("What is the balance : ");
        balance = Try(balance);
        Console.WriteLine();

        Console.Write("what is Your withdraw :");
        withdrow = Try(withdrow);
        Console.WriteLine();
        newbalance = Withdrow(balance, withdrow);
        Console.WriteLine("Yor balance is €{0}", newbalance);



        Console.ReadKey();
    }// end main

    static int Withdrow(int balance, int withdrow)
    {
        int newbalance = 0;

        if (balance >= withdrow)
        {
            newbalance = balance - withdrow;
        }
        else
        {
            Console.WriteLine("Ther are not sufficient funds");
            newbalance = balance;
        }

        return newbalance;
    }
    static int Discount(int days)
    {
        int discount = 0;

        switch (days)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
                discount = 0;
                break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
                discount = 5;
                break;
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
            case 21:
                discount = 10;
                break;
            default:
                discount = 15;
                break;

        }

        return discount;
    }
    static bool Sorted(ref int x, ref int y, ref int z)
    {
        int empty;

        if (x > y)
        {
            empty = x;
            x = y;
            y = empty;
            //Console.WriteLine(x+y);
            //Console.ReadKey();
        }
        if (x > z)
        {
            empty = x;
            x = z;
            z = empty;

        }
        if (y > z)
        {
            empty = y;
            y = z;
            z = empty;

        }
        bool sort = true;

        return sort;
    }
    static string Reverse(string str)
    {

        return new string(str.ToCharArray().Reverse().ToArray());

        /*
        http://tipsandtricks.runicsoft.com/CSharp/StringReverse.html
            */
    }


    static int Try(int num)//Menu printed on start of the program
    {
        bool correct = false;
        string text = "";

        while (correct == false)
        {

            text = Console.ReadLine();

            // catch errors
            try
            {
                num = int.Parse(text);
                correct = true;
            }
            catch (Exception e)  // Get the error message out of the exception 
            {
                Console.WriteLine(e.Message);
            }
        }
        return num;
    }

    static int CarRent(int days)
    {
        int price = 0;


        if (days > 3)
        {

            days -= 3;
            price = (days * 15) + 30;
        }
        else
            price = days * 20;

        if (price < 50)
            price = 50;
        return price;
    }




}

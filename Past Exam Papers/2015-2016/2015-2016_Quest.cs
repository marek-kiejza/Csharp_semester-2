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
        char code;
        int points = 0;
        Console.Write("Write a character code: ");
        code = Console.ReadKey().KeyChar;
        code=char.ToUpper(code);
       points = BonusPoints(code);
        Console.WriteLine();
        Console.WriteLine("You receive {0} bonus points",points);
         Console.ReadKey();
         */
        //QII
        /*
        int num1 = 0, num2 = 0;
        int sumOdd = 0;
        Console.Write("Insert First number : ");
        num1 = Try(num1);
        Console.WriteLine();
        Console.Write("Insert Second number : ");
        num2 = Try(num2);
        sumOdd = SumOddNums(num1,num2);
        Console.WriteLine("The Sum of odd Numbers is : {0}",sumOdd);
        Console.ReadKey();
        */

        //QIII
        /*
        string text = "";
        bool check;
        Console.Write("Type a text : ");
        text = Console.ReadLine();
        check = CheckGet(text);
        Console.WriteLine("This text end with \"get\" : {0}",check);
        Console.ReadKey();
        */

        //QIV
        /*
        int size=0;
        double aver = 0;
        Console.Write("How many numbers ");
        size = Try(size);
        int[] arr = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            Console.Write("Type int nr{0} : ",i+1);
            arr[i] = Try(arr[i]);
            Console.WriteLine();
        }
        aver = AverageSecond(arr,size);
        Console.WriteLine("Average of every second element is : {0:.0}",aver);
        Console.ReadKey();
        */

        //QV

        int a = 0, b = 0;

        Console.Write("Type first int : ");
        a = Try(a);
        Console.WriteLine();
        Console.Write("Type secend int : ");
        b = Try(b);
        Console.WriteLine();
        HalfInt(ref a, ref b);

        Console.WriteLine("Half of int is:");
        Console.WriteLine("-firsy : {0}", a);
        Console.WriteLine("-secend : {0}", b);

        Console.ReadKey();

        //Console.OutputEncoding = System.Text.Encoding.UTF8;
    }// end main
    static void HalfInt(ref int a, ref int b)
    {
        a = a / 2;
        b = b / 2;

    }
    static double AverageSecond(int[] arr, int size)
    {
        int total = 0;
        double div = 0;
        double average = 0;

        for (int i = 0; i < size; i += 2)
        {
            total += arr[i];
            div++;
        }
        average = total / div;
        return average;
    }
    static bool CheckGet(string text)
    {
        bool check = false;
        if (text.EndsWith("get"))
        {
            check = true;
        }

        return check;
    }
    static int SumOddNums(int n1, int n2)
    {
        int sumOdd = 0;
        if (n1 % 2 != 0)
            n1++;

        for (int i = n1; i <= n2; i += 2)
        {
            sumOdd += i;
        }

        return sumOdd;
    }
    static int BonusPoints(char code)
    {
        int points = 0;
        switch (code)
        {
            case 'A':
                points = 50;
                break;

            case 'S':
            case 'H':
            case 'J':
                points = 100;
                break;

            case 'Q':
                points = 200;
                break;

            default:
                points = 0;
                break;
        }

        return points;
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




}

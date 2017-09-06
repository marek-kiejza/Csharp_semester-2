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
        int length = 0;
        double total = 0;
        int[] players;
        players = PrintMenu();
        length = PrintStars(players);
        total = Total(players, length);
        Average(total, length);
        HighScore(players);

        Console.ReadKey();

    }// end main

    static int[] PrintMenu()//Menu printed on start of the program
    {

        string result = "";

        int i = 1;
        int[] star = new int[6];

        while (i < star.Length)
        {
            Console.Write("Enter score for player {0}  ", i);

            result = Console.ReadLine();

            // catch errors
            try
            {
                star[i] = int.Parse(result);
                i++;
            }
            catch (Exception e)  // Get the error message out of the exception 
            {
                Console.WriteLine(e.Message);
            }
        }
        return star;
    }

    static int PrintStars(int[] players)
    {
        int length = 0;
        int y = 1;
        int sum = 0, star = 0;
        length = players.Length;
        Console.WriteLine();
        while (y < players.Length)
        {
            sum += players[y];
            star = players[y] / 100;
            Console.Write("Enter score for player " + y);
            for (int i = 0; i < star; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            y++;
        }
        return length;
    }
    static double Total(int[] player, int length)
    {

        double sum = 0;
        Console.WriteLine();
        for (int i = 0; i < length; i++)
        {
            sum += player[i];
        }
        Console.WriteLine("Total Score : {0:#,###.00}", sum);
        return sum;
    }

    static void Average(double total, int length)
    {
        length--;
        Console.WriteLine();
        double average = 0;

        average = total / length;
        Console.WriteLine("Average Score : {0:#,###.00}", average);

    }


    static void HighScore(int[] players)
    {
        int highscore = 0;
        Console.WriteLine();
        for (int i = 1; i < players.Length; i++)
        {
            if (players[i] > highscore)
            {
                highscore = players[i];
            }

        }
        Console.WriteLine("Highest Score    {0}", highscore);

    }
}

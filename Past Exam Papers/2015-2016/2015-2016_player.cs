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
        int filleLength;
        string[,] arrey;
        int[,] countArr;

        CreateFile();

        filleLength = LineCount();
        arrey = WriteArray(filleLength);
        countArr = Analysis(arrey, filleLength);// call appropriate method(s)
        Print(countArr);

        Console.ReadKey();

    }// end main
    static void CreateFile()
    {
        // create a connection to the file
        StreamWriter sw = new StreamWriter(@"C:\Users\s00173510\Desktop\PROJECT_MK\scores2.txt"); // placed the file in the debug folder, so no path needed

        //write to file
        sw.WriteLine("G001,Female,0");
        sw.WriteLine("G001,Female,0");
        sw.WriteLine("G001,Female,0");
        sw.WriteLine("G001,Female,0");
        sw.WriteLine("G001,Female,0");

        sw.WriteLine("G001,Female,1");
        sw.WriteLine("G001,Female,1");

        sw.WriteLine("G001,Female,2");
        sw.WriteLine("G001,Female,2");
        sw.WriteLine("G001,Female,2");
        sw.WriteLine("G001,Female,2");
        sw.WriteLine("G001,Female,2");

        sw.WriteLine("G001,Female,3");
        sw.WriteLine("G001,Female,3");
        sw.WriteLine("G001,Female,3");
        sw.WriteLine("G001,Female,3");

        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");
        sw.WriteLine("G001,Female,4");

        sw.WriteLine("G001,Male,0");
        sw.WriteLine("G001,Male,0");
        sw.WriteLine("G001,Male,0");
        sw.WriteLine("G001,Male,0");
        sw.WriteLine("G001,Male,0");

        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");
        sw.WriteLine("G001,Male,1");

        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");
        sw.WriteLine("G001,Male,2");

        sw.WriteLine("G001,Male,3");
        sw.WriteLine("G001,Male,3");
        sw.WriteLine("G001,Male,3");

        sw.WriteLine("G001,Male,4");
        sw.WriteLine("G001,Male,4");



        // close the connection to the file
        sw.Close();
    }
    static int LineCount()// count numbers of lines in the scores.txt
    {
        StreamReader sr = new StreamReader(@"C:\Users\s00173510\Desktop\PROJECT_MK\scores2.txt");
        int counte = 0;

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            counte++;
        }

        return counte;
    }
    static string[,] WriteArray(int size)
    {
        int y = 0;

        StreamReader sr = new StreamReader(@"C:\Users\s00173510\Desktop\PROJECT_MK\scores2.txt");
        string[] fields = new string[2];// array to store chopped up line
        string[,] arreyAll = new string[size, 3];

        string lineIn;// will hold data that we read in

        lineIn = sr.ReadLine();// read in first line from file

        while (lineIn != null)// null signals end of the file
        {

            fields = lineIn.Split(','); // split lineIn where there is a ','

            for (int i = 0; i < 3; i++)
            {
                arreyAll[y, i] = fields[i];

            }
            y++;
            lineIn = sr.ReadLine();// read in the next line
        }
        return arreyAll;
    }

    static int[,] Analysis(string[,] arrey, int count)//Score Analysis Report method
    {
        int z = 0;
        int numer = 0;
        int hightScore = 0;

        int[] age = { 0, 1, 2, 3, 4, 5 };
        int[,] countArr = new int[7, 3];// 2D array to store data

        while (count > 0)
        {

            hightScore = int.Parse(arrey[z, 2]);//Convert string to int      

            numer += hightScore;

            //Assign value to 2d array location

            for (int y = 0; y < age.Length - 1; y++)
            {
                if (hightScore == age[y])
                {
                    countArr[y, 0]++;
                    if (arrey[z, 1] == "Female")
                    {
                        countArr[y, 1]++;
                        countArr[6, 1]++;
                    }
                    else
                    {
                        countArr[y, 2]++;
                        countArr[6, 2]++;
                    }
                }
            }
            countArr[6, 0]++;
            z++;
            count--;

        }//while end
        return countArr;
    }

    static void Print(int[,] countArr)
    {
        // print to screen
        string[] score = { "Under 20", "20-29", "30-39", "40-49", "50 +", };
        Console.WriteLine("Score Range {0,14}{1,17}{2,9}", "Count", "Female", "Male");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("{0,-9}", score[i]);
            for (int y = 0; y < 3; y++)
            {
                Console.Write("{0,13}", countArr[i, y]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Totals{0,16}{1,13}{2,13}", countArr[6, 0], countArr[6, 1], countArr[6, 2]);
        //int averag
    }



}

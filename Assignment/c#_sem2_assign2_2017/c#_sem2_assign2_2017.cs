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

        CreateFile();
        int count = LineCount();

        int menuChoice = PrintMenu();

        while (menuChoice != 4)  // in the case 4 is the exit option
        {
            // process choice

            switch (menuChoice)
            {
                case 1:
                    Console.Clear();
                    Format(count);// call appropriate method(s)
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Analysis();// call appropriate method(s)
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Serch();// call appropriate method(s)
                    Console.ReadKey();
                    break;

                default:  // something other than 1,2,3,4
                    Console.WriteLine("Invalid menu choice");
                    Console.ReadKey();
                    break;

            }//end switch

            menuChoice = PrintMenu();    //call menu again

        } // end while

        //finish program
        Console.WriteLine("See you next time!");
        Console.ReadKey();

    }// end main
    static void CreateFile()
    {
        // create a connection to the file
        StreamWriter sw = new StreamWriter(@"scores.txt"); // placed the file in the debug folder, so no path needed

        //write to file
        sw.WriteLine("G001,Florence Ryan,Spanish,280");
        sw.WriteLine("G002,Sebastian Jones,Irish,650");
        sw.WriteLine("G003,Isabella Kelly,French,720");

        // close the connection to the file
        sw.Close();
    }
    static int PrintMenu()//Menu printed on start of the program
    {


        string result = "";
        int resultInt = 0;
        Console.Clear();
        Console.WriteLine("Menu\n");
        Console.WriteLine("1.Player Report");
        Console.WriteLine("2.Score Analysis Report");
        Console.WriteLine("3.Search for a Player");
        Console.WriteLine("4.Exit");
        Console.WriteLine();
        Console.Write("Enter Choice : ");
        result = Console.ReadLine();

        // catch errors
        try
        {
            resultInt = int.Parse(result);
        }
        catch (Exception)// Get the error out of the exception 
        { }

        return resultInt;
    }

    static int LineCount()// count numbers of lines in the scores.txt
    {
        StreamReader sr = new StreamReader(@"scores.txt");
        int counte = 0;

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            counte++;
        }

        return counte;
    }
    static void Format(int num)//Report Format method
    {
        string firstName = "";
        string last_name = "";

        int topPlayer = 0;
        int hightScore = 0;
        double average = 0;
        StreamReader sr = new StreamReader(@"scores.txt");

        string[] fields = new string[4];// array to store chopped up line

        int lineCount = 0;// variable to accumulate numbers of lines in the scores.txt
        string lineIn;// will hold data that we read in

        int[] numer = new int[num];// array to store chopped up score and pass to other methods
        Console.WriteLine("{0}{1,14}{2,25}", "Player Name", "Score", "Star Rating\n");
        lineIn = sr.ReadLine();// read in first line from file

        while (lineIn != null)// null signals end of the file
        {

            fields = lineIn.Split(',', ' ');// split lineIn where there is a ','or  ' '

            // print to screen
            Console.Write("{0}{1,-10}{2,10}", fields[1].Substring(0, 1) + ". ", fields[2], fields[4]);

            hightScore = int.Parse(fields[4]);//Convert string to int  
            StarRating(hightScore);//Call method

            if (topPlayer < hightScore)
            {
                topPlayer = hightScore;

                firstName = fields[1];
                last_name = fields[2];

            }

            numer[lineCount] = hightScore;// store int  score to pass to methods

            lineIn = sr.ReadLine();// read in the next line
            lineCount++;

        }//while end

        // print to screen
        Console.WriteLine();
        average = Average(numer, lineCount); //methods to calculate average
        Standart(numer, lineCount, average);//methods to calculate standard deviation 
        Console.WriteLine("Top Player{0,19}", firstName.Substring(0, 1) + "." + last_name.Substring(0, 1) + ".");// top player initials

    }
    static double Average(int[] readIn, int count)//methods to calculate average
    {
        double average = 0;
        for (int i = 0; i < readIn.Length; i++)
        {
            average += readIn[i];
        }

        average = average / readIn.Length;
        Console.WriteLine("Average Score{0,15}", average);

        return average;
    }
    static void Standart(int[] readIn, int count, double average)//methods to calculate standard deviation 
    {
        const int POWER_OF_TWO = 2;
        double sumOfSquer = 0;

        double result = 0;
        for (int i = 0; i < readIn.Length; i++)
        {
            sumOfSquer += Math.Pow(readIn[i], POWER_OF_TWO);
        }

        result = Math.Sqrt((sumOfSquer / readIn.Length) - (Math.Pow(average, POWER_OF_TWO)));

        Console.WriteLine("Pop Standard Deviation{0,9:f2}", result);

    }

    static void Analysis()//Score Analysis Report method
    {

        int numer = 0;
        int hightScore = 0;
        StreamReader sr = new StreamReader(@"scores.txt");
        string[] fields = new string[4];// array to store chopped up line
        string[] score = { "Under 400", "400-599", "600-699", "700-999", "1000 +", };
        int[,] countArr = new int[5, 3];// 2D array to store data

        int lineCount = 0, irish = 0, nonIrish = 0;
        string lineIn;// will hold data that we read in
        lineIn = sr.ReadLine();// read in first line from file

        while (lineIn != null)// null signals end of the file
        {

            fields = lineIn.Split(',', ' '); // split lineIn where there is a ','or  ' '


            hightScore = int.Parse(fields[4]);//Convert string to int           
            numer += hightScore;

            //Assign value to 2d array location
            if (hightScore < 400)
            {
                countArr[0, 0]++;
                if (fields[3] == "Irish")
                {
                    countArr[0, 2]++;
                    irish++;
                }
                else
                {
                    countArr[0, 1]++;
                    nonIrish++;
                }
            }
            else if (hightScore >= 400 && hightScore <= 599)
            {
                countArr[1, 0]++;
                if (fields[3] == "Irish")
                {
                    countArr[1, 2]++;
                    irish++;
                }
                else
                {
                    countArr[1, 1]++;
                    nonIrish++;
                }
            }
            else if (hightScore >= 600 && hightScore <= 699)
            {
                countArr[2, 0]++;
                if (fields[3] == "Irish")
                {
                    countArr[2, 2]++;
                    irish++;
                }
                else
                {
                    countArr[2, 1]++;
                    nonIrish++;
                }
            }
            else if (hightScore >= 700 && hightScore <= 999)
            {
                countArr[3, 0]++;
                if (fields[3] == "Irish")
                {
                    countArr[3, 2]++;
                    irish++;
                }
                else
                {
                    countArr[3, 1]++;
                    nonIrish++;
                }
            }
            else
            {
                countArr[4, 0]++;
                if (fields[3] == "Irish")
                {
                    countArr[4, 2]++;
                    irish++;
                }
                else
                {
                    countArr[4, 1]++;
                    nonIrish++;
                }
            }


            lineCount++;

            lineIn = sr.ReadLine();// read in the next line


        }//while end

        // print to screen

        Console.WriteLine("Score Range {0,14}{1,17}{2,9}", "Count", "Non-Irish", "Irish");
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
        Console.WriteLine("Totals{0,16}{1,13}{2,13}", lineCount, nonIrish, irish);

    }

    static void StarRating(int rating)//Call method printing stars
    {
        //assign numbers of stars by score
        if (rating < 400)
        {
            Console.WriteLine("{0,16}", "*");
        }
        else if (rating >= 400 && rating <= 599)
        {
            Console.WriteLine("{0,17}", "**");
        }
        else if (rating >= 600 && rating <= 699)
        {
            Console.WriteLine("{0,18}", "***");
        }
        else if (rating >= 700 && rating <= 999)
        {
            Console.WriteLine("{0,19}", "****");
        }
        else
        {
            Console.WriteLine("{0,20}", "*****");
        }

    }
    static void Serch()//Call method to serch for user
    {
        bool found = false;
        string playerNumber = "", name = "", score = "";

        Console.Write("Enter Player Number: ");
        playerNumber = Console.ReadLine().ToUpper();
        StreamReader sr = new StreamReader(@"scores.txt");
        string[] fields = new string[4];// array to store chopped up line



        int lineCount = 0;
        string lineIn;// will hold data that we read in
        lineIn = sr.ReadLine();// read in first line from file

        while (lineIn != null)// null signals end of the file
        {

            fields = lineIn.Split(',', ' ');// split lineIn where there is a ','or  ' '
            if (fields[0] == playerNumber)
            {
                name = fields[1];
                score = fields[4];
                found = true;
                break;
            }
            lineIn = sr.ReadLine();// read in next line from file
            lineCount++;

        }//while end

        // print out serch result
        if (found == true)
        {
            Console.WriteLine();
            Console.WriteLine("Player name : {0}", name);
            Console.WriteLine();
            Console.WriteLine("Score       : {0} ", score);
        }
        else
            Console.WriteLine("No match found");
    }


}

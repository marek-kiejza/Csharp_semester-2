using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
           // ReadFile();
            Q3();
            Console.ReadLine();
        }

        static void ReadFile()
        {
            StreamReader sr = new StreamReader(@"H:\Semestr2\C#\FilleHandling\temp.txt");

            string[] fields = new string[2];



            string lineIn;
            lineIn = sr.ReadLine();

            int total = 0;
            int lineCount = 0;

            Console.WriteLine("{0,-15}{1,-10}", "Data", "Temperature");
            while (lineIn != null)//read 3 lines
            {

                fields = lineIn.Split(',');
                Console.WriteLine("{0,-15}{1,-10}", fields[0], fields[1]);

                total += int.Parse(fields[1]);

                lineCount++;
                lineIn = sr.ReadLine();

            }

            double avgTemp = (double)total / lineCount;
            Console.WriteLine("Average Temp = {0}", avgTemp);

        }

        static void Q3()
            {
              StreamReader sr = new StreamReader(@"H:\Semestr2\C#\FilleHandling\temp.txt");

        string[] fields = new string[1];

        string[] range = new string[4];

            string lineIn;
        lineIn = sr.ReadLine();

            int total = 0;
        int lineCount = 0;
            Console.WriteLine("Range Report");
        Console.WriteLine("{0,-15}{1,-10}", "Range", "Number of Days");
            while (lineIn != null)//read 3 lines
            {
               
                fields = lineIn.Split(',');
                Console.WriteLine("{0,-15}{1,-10}", fields[0], range[1]);

                int myTemp = int.Parse(fields[1]);
                if (myTemp<0)
                    range[0]+=1;

                if (myTemp > 0 && myTemp <=9)
                    range[1] += 1;

                if (myTemp > 10 && myTemp <= 19)
                    range[2] += 1;

                if (myTemp > 19 && myTemp <= 30)
                    range[3] += 1;

                if (myTemp > 30)
                    range[4] += 1;

                Console.WriteLine("{0,-15}{1,-10}", fields[0], range[0]);
                lineCount++;
                lineIn = sr.ReadLine();

            }
            Console.WriteLine("{0,-15}{1,-10}", fields[0], range[0]);


            double avgTemp = (double)total / lineCount;
    Console.WriteLine("Average Temp = {0}", avgTemp);
        }
    }
}

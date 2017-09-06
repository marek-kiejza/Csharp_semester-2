using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateFile();
            ReadFile();

            Console.ReadLine();
        }

        static void CreateFile()
        {
            // create a connection to the file
            StreamWriter sw = new StreamWriter(@"H:\Semestr2\C#\FilleHandling\myfile.txt");

            //write to file
            sw.WriteLine("So by colonel hearted ferrars");
            sw.WriteLine("Draw from upon here gone add one.");
            sw.WriteLine("He in sportsman household");

            //close connection
            sw.Close();
        }

        static void ReadFile()
        {
            StreamReader sr = new StreamReader(@"H:\Semestr2\C#\FilleHandling\myfile.txt");
            int lineCount = 0;//for 3 only
            string lineIn;
            lineIn = sr.ReadLine();

           while (lineIn != null)//read 3 lines
            {
                lineCount++;//for 3 only

                if (lineCount == 3)//for 3 only
                    Console.WriteLine(lineIn);

                    lineIn = sr.ReadLine();
              
            }
           // Console.WriteLine(lineIn);//Read only one line
            sr.Close();


        }
    }
}

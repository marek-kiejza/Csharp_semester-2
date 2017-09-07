using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
       public static void Main(string[] args)
        {
            int[] score = new int[11];
            for(int i = 0;i<11;i=i+1)
            {
                score[i] = readInt("Score : ", 0, 1000);
            }

            for (int i = 0; i < 11; i = i + 1)
            {
                Console.WriteLine(score[i]);
            }

            Console.ReadLine();
        }

        static string readString(string prompt)
        {
            string result;
            do {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == ""); return result;
        }

        static int readInt(string prompt, int low, int high)
        {
            int result;

            do { string intString = readString(prompt);
                result = int.Parse(intString);
            } while ((result < low) || (result > high));

            return result;
        }
    }
}

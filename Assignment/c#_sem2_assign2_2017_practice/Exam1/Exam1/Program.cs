using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Autor: Marek Kiejza s00173510
Program description Cautious Insurance sells car insurance policies.  
It requires an application to calculate insurance premiums.
*/
namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int value = 0;
            do
            {
                Console.Clear();
                int age = 0, points = 0 ,pointsCharg=0;
                string gender = "";
                double result;
                value = GetDouble("Enter Vehicle value : ",value);
                // skipp this part when -999 is enter in value
                if (value != -999)// skipp this part when -999 is enter in value
                {
                    gender = GetString("Enter Gender : ", gender);//Use Method to a Read String

                    age = GetDouble("Enter Age : ", age);//Use Method to Read a Int

                    points = GetDouble("Enter penalty points : ", points);//Use Method to Read a Int

                    pointsCharg = Switch(points);//Use Method to get a switch

                   result= IfStat(value, gender, age, pointsCharg);//use Method IfStat for calculation

                   Console.WriteLine("Your Premium quote is : {0:f2}", result);//result of calculation

                   Console.ReadLine();
                }
            } while (value != -999);//loop repeat until a vehicle value of -999 is entered
        }


        static private int GetDouble(string text,int number)//Method to Read Int
        {
            Console.Write(text);
            number = int.Parse(Console.ReadLine());

            return number;

        }

        static private string  GetString(string text, string writeText)//Method to Read String
        {
            Console.Write(text);
            writeText = Console.ReadLine().ToUpper();

            return writeText;

        }

        static private int Switch(int value)
            //Method for switch statment to calculate panelty poinds extra charge
        {
            switch (value)
            {
                case 0:
                    value = 0;
                    Console.WriteLine("No extra charge");
                    break;

                case 1:
                case 2:
                case 3:
                case 4:
                    value = 100;
                    break;

                case 5:
                case 6:
                case 7:
                    value = 200;
                    break;

                case 8:
                case 9:
                case 10:
                    value = 300;
                    break;

                case 11:
                case 12:
                    value = 400;
                    break;

                default:
                    value = 0;
                    Console.WriteLine("Inform the user “No Quote POSSIBLE”");
                     break;
            }
            return value;

        }

        static private double IfStat(double value,string gender,int age ,int pointsCharg)
        //Method for If statment to calculate the insurance premium 
        {
            double results = 0;

            const double PER1 = 0.03, PER2 = 1.1, PER3 = 1.06, AGE_MALE = 25, AGE_FEMALE = 21;

            if(gender=="MALE" && age < AGE_MALE)
            results = ((value * PER1) * PER2) + pointsCharg;

            else if (gender == "FEMALE" && age < AGE_FEMALE)
                results = (value * PER1) * PER3 + pointsCharg;

            else
                results = (value * PER1) + pointsCharg;

            return results;
           
        }
    }

}

using System;
class UsefulMethod
{
    static double readValue
        (    // prompt for the user         
        double low,                                          // lowest allowed value      
        double high,
        string age,
        string error
        )
    {
        double result = 0;

        do
        {
            Console.WriteLine(age + "between " + low + " and " + high + "Age not void" + error);
            string resultString = Console.ReadLine();
            result = double.Parse(resultString);

        } while ((result < low) || (result > high));
        return result;
    }

    public static void Main()
    {
        double age = readValue(0, 70, "Enter your age", "Age not voiddupa");

        Console.WriteLine("Age: " + age);
        Console.ReadKey();
    }
}
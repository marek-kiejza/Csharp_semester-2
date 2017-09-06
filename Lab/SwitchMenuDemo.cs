
using System;

class Game
{
	static void Main()
	{
		
		
		string menuChoice = PrintMenu();
	
		while (menuChoice != "D")  // in the case D is the exit option
		{
			// process choice
		
			switch (menuChoice)
			{
				case "A":
					Console.WriteLine("play 1 player game ");
                    // call appropriate method(s)
					break;
				case "B":
                    Console.WriteLine("play 2 player game ");
                    // call appropriate method(s)
                    break;
				case "C":
					Console.WriteLine("play multi player game ");
                    // call appropriate method(s)
                    break;
				default:  // must be something other than A,B,C
					Console.WriteLine("Invalid menu choice");
					break;
				
			
			}//end switch

            //call menu again

            menuChoice = PrintMenu();	
		
		} // end while
	
	

	}// end main

    static string PrintMenu()
    {
        Console.WriteLine("game menu");
        Console.WriteLine("A	1 player");
        Console.WriteLine("B	2 player");
        Console.WriteLine("C	Multi player");
        Console.WriteLine("D	Exit");
        Console.WriteLine("\nEnter choice : ");
        string result = Console.ReadLine().ToUpper();

        return result;
    }




}


using System;

class Game
{
	static void Main()
	{
		
		Console.WriteLine("game menu");
		Console.WriteLine("A	1 player");
		Console.WriteLine("B	2 player");
		Console.WriteLine("C	Multi player");
		Console.WriteLine("D	Exit");
		Console.WriteLine("\nEnter choice : ");
		string menuChoice = Console.ReadLine().ToUpper();
	
		while (menuChoice != "D")
		{
			// process choice
		
			switch (menuChoice)
			{
				case "A":
					Console.WriteLine("play 1 player game ");
					break;
				case "B":
					Console.WriteLine("play 2 player game ");
					break;
				case "C":
					Console.WriteLine("play multi player game ");
					break;
				default:
					Console.WriteLine("Invalid menu choice");
					break;
				
			
			}//end switch
		
		    //print menu again (a lot better as a method)

			Console.WriteLine("game menu");
			Console.WriteLine("A	1 player");
			Console.WriteLine("B	2 player");
			Console.WriteLine("C	Multi player");
			Console.WriteLine("D	Exit");
			Console.WriteLine("\nEnter choice : ");
			menuChoice = Console.ReadLine().ToUpper();
	
		
		} // end while
	
	
	}

	


}

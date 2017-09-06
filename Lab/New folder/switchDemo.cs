


static void Main()

{
	string message;
	int dayNumber;
	Console.Write ("Enter day number : ");
	dayNumber = Convert.ToInt32(Console.ReadLine());
	
	switch (dayNumber)
	{
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
			message = "Week Day";
			break;
		case 6:
		case 7:
			message = "Weekend Day";
			break;
		default
			meassage = "Invalid";
			break;	
			
	}
	
	Console.WriteLine(message);
	
	
	 





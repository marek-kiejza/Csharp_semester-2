using System;

class Demo1
{

	static string myAddress; // can be seen by all methods in the class
	
	
static void Main()
{
	int myAge = 23;
	string myName = "pat";
	
	Console.WriteLine("In main");
	
	Greeting(myName,myAge); // pass by value - only giving a copy

	Console.WriteLine("Back In main");
	
	
}


static void Greeting(string nameIn, int ageIn)
{

	Console.WriteLine("Hello {0}, you are {1}", nameIn, ageIn);
	//Greeting2();
}

static void Greeting2()
{
	Console.WriteLine("Welcome to sligo ");
}

}




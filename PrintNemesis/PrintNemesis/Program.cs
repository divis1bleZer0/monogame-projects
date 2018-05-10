using System;

namespace PrintNemesis
{

    // A class that prints the name of my nemesis
    class MainClass
    {
     
      // Method for printing name
      public static void Main(string[] args)
      {
		Console.Write("Enter the name of your nemesis: ");
		string nem = Console.ReadLine();
        
		Console.WriteLine();
		Console.WriteLine(nem + " has returned!");
       
        Console.WriteLine();


      }
    }  
}

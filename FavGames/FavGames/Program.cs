using System;

namespace FavGames
{

    // A class that prints the name of my nemesis
    class MainClass
    {
     
      // Method for printing name
      public static void Main(string[] args)
      {
		// get favorite games		
		Console.Write("Enter your favorite game: ");        
		string game1 = Console.ReadLine();
		Console.Write("Enter your next favorite game: ");		
		string game2 = Console.ReadLine();
		Console.Write("Enter your next favorite game: ");	
		string game3 = Console.ReadLine();

		// print favorite games
		Console.WriteLine();		
		Console.WriteLine("Your favorite games are: ");
		Console.WriteLine(game1);
        Console.WriteLine(game2);
        Console.WriteLine(game3);
       

        Console.WriteLine();


      }
    }  
}

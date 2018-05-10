using System;

namespace GameMenu
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// create a menu
			Console.WriteLine("***************");
			Console.WriteLine("Menu:");
			Console.WriteLine("");
			Console.WriteLine("N - New Game");
			Console.WriteLine("L - Load Game");
			Console.WriteLine("O - Options");
			Console.WriteLine("Q - Quit");
			Console.WriteLine("***************");
			Console.WriteLine("");

			// prompt for and read in menu selection 
			Console.Write("Select a menu option: ");
			char menuSelecton = Console.ReadLine()[0];

			// determine which option was selected and print response
			if (menuSelecton == 'N' ||
			    menuSelecton == 'n')
			{
				Console.WriteLine("Sarting new game...");
			}
			else if (menuSelecton == 'L' ||
			         menuSelecton == 'l')
			{
				Console.WriteLine("Loading game...");
			}
			else if (menuSelecton == 'O' ||
			         menuSelecton == 'o')
			{
				Console.WriteLine("Entering options menu...");
			}
			else if (menuSelecton == 'Q' ||
			         menuSelecton == 'q')
			{
				Console.WriteLine("Quitting game...");
			}
			else
			{
				Console.WriteLine("Selection is not available");
			}

			Console.WriteLine();


		}
	}
}

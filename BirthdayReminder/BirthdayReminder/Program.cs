using System;

namespace BirthdayReminder
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// get month
			Console.Write("Enter the month you were born: ");
			string month = Console.ReadLine();

			// get day
			Console.Write("Enter the day (number) you were born: ");
			int day = int.Parse(Console.ReadLine());

			// print day and month
			Console.WriteLine("You were born on " + month + " " + day);
			Console.WriteLine("You will be reminded of your birthday on " 
                              + month + " " + (day - 1));
		}
	}
}

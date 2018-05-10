using System;
using System.Collections.Generic;
namespace AverageNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// create list of numbers
			List<int> numbers = new List<int>();

			// prompt for positive integer
			Console.Write("Enter a list of positive integers (-1 when finished): ");
			int n = int.Parse(Console.ReadLine());

			// check if number is -1
			while (n != -1)
			{
				

				// check if number is greater than or equal to 0
				while (n >= 0)
				{
					
					// add positive integers to the list
					numbers.Add(n);

					// prompt for next value
					Console.Write("Enter a list of positive integers (-1 when finished): ");
					n = int.Parse(Console.ReadLine());
				}

				// 
				while (n < -1)
				{
					Console.WriteLine("Incorrect input.  Number not added to list.");
					Console.Write("Enter a list of positive integers (-1 when finished): ");
					n = int.Parse(Console.ReadLine());
				}
			}
			// find maximum value of list
			int max = numbers[0];
			foreach (int number in numbers)
			{
				if (number > max)
				{
					max = number;
				}
			}

			int avgCount = 0;
			int averageAdd = 0;
			foreach (int number in numbers)
			{
				avgCount = avgCount + 1;
				averageAdd = averageAdd + number;
			}

			int average = averageAdd / avgCount;
			Console.WriteLine("Average of numbers: " + average);

			}
		}
	}

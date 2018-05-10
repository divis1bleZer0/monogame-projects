using System;

namespace DistanceBetweenPoints
{
	/// <summary>
	/// Caclulates the sides and angles of a triangle
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Finds the distance between two points and the angle that they make
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
			// Print welcome message
			Console.WriteLine("Welcome! This program will solve for the distance between two points "
							  + "as well as the the angle between them.");

			// Prompt for x and y values from points
			Console.WriteLine("Please enter the first point (1x): ");
			float point1X = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the second point (1y): ");
			float point1Y = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the third point (2x): ");
			float point2X = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the fourth point (2y): ");
			float point2Y = float.Parse(Console.ReadLine());

			//Calculate delta x and delta y
			float deltaX = point2X - point1X;
			float deltaY = point2Y - point1Y;

			// Calculate the distance between the points and the angle
			var distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
		
			var angle = (Math.Atan2(deltaY, deltaX) * 180.0 / Math.PI);

			// Print calculation
			Console.WriteLine("Thank you! The distance between the two points is " + 
			                  String.Format("{0:0.000}", distance)
			                  + " and the angle that they make is " + 
			                  String.Format("{0:0.000}", angle) + " .");

			Console.WriteLine();
		}
	}
}

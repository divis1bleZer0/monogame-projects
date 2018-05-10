using System;

namespace ConvertTemp
{

    // A class that converts and prints conversion between f and c then back
    class MainClass
    {
     
      // Declare and convert temp then print
      public static void Main(string[] args)
      {
        // Obtain original temp in f
        Console.Write("Enter temperature (Fahrenheit): ");
        float originalFahrenheit = float.Parse(Console.ReadLine());
        
        // Convert temp to c
        float calculatedCelcius = ((((originalFahrenheit - 32)) / 9) * 5);

        // Convert c to f
        float calculatedFahrenheit = ((((calculatedCelcius * 9) / 5)) + 32);

       // Print calculation
        Console.WriteLine(originalFahrenheit + " degrees Fahrenheit is " + calculatedCelcius + " degrees Celcius");
        Console.WriteLine(calculatedCelcius + " degrees Celcius is " + calculatedFahrenheit + " degrees Fahrenheit");
       
        Console.WriteLine();


      }
    }  
}

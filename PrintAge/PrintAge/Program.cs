using System;

namespace PrintAge
{

    // A class that prints my age
    class MainClass
    {
     
      // Declare age integer
      public static void Main(string[] args)
      {
       // Declare integer variable
       Console.Write("Enter your age: ");
       string age = Console.ReadLine();

       // Print age
       Console.WriteLine();
       Console.WriteLine("You are " + age + " years old.");
       
       Console.WriteLine();


      }
    }  
}

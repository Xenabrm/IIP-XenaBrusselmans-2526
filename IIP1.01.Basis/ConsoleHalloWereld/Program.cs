/*
 * Auteur: Rogier van der Linde
 * Datum: 2025-09-05
 */
using System;

namespace ConsoleHalloWereld
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hallo Wereld!");
		 Console.Write("Hoe heet je: ");
		 string name = Console.ReadLine();
         Console.WriteLine($"Hallo, {name}");	
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine($"Aangename kennismaking, {name}");
         Console.ResetColor();		 
		 Console.WriteLine("Druk een toets om verder te gaan...");
		 Console.ReadKey();  		 
      }
   }
}

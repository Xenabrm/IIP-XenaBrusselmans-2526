/*
 * Auteur: Rogier van der Linde
 * Datum: 2025-09-05
 */
using System;

namespace ConsoleGansterName
{
   class Program
   {
      static void Main(string[] args)
      {
        
		 string title = "GANGSTA NAME BUILDER";
		 string header = $@"************************
| {title} |
************************";
		 Console.WriteLine(header);
		 Console.Write("Give the first name of any Disney character: ");
		 string firstName = Console.ReadLine();
		 Console.Write("Give any workbench tool: ");
		 string tool = Console.ReadLine();
		 Console.Write("What is your last name: ");
		 string lastName = Console.ReadLine();
		 Console.WriteLine();
		 Console.ForegroundColor = ConsoleColor.Green;
		 string gangstaName = $"{firstName} \"the {tool}\" {lastName}";
		 Console.WriteLine($"Your gangsta name: {gangstaName}");
		 Console.ResetColor();
		 Console.WriteLine("Press any key to exit...");
		 Console.ReadKey();  		 
      }
   }
}
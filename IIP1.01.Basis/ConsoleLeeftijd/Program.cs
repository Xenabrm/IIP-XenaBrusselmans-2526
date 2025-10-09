/*
 * Auteur: Rogier van der Linde
 * Datum: 2025-09-05
 */
using System;

namespace ConsoleLeeftijd
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Wat is je voornaam? ");
		 string firstName = Console.ReadLine();
		 Console.WriteLine("Hoe oud ben je? ");
		 string age = Console.ReadLine();
		 Console.WriteLine("Geef je lievelingsletter: ");
		 string letter = Console.ReadLine();
		 Console.WriteLine($"Hallo {firstName}! Jij bent {age} jaar");
		 Console.WriteLine($"Volgend jaar ben je 22.");
		 Console.WriteLine($"Jouw lievelingsletter is: {letter}");
		 Console.ReadKey();       
      }
   }
}
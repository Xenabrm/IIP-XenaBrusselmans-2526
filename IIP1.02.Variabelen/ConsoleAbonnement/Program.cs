using System;

namespace ConsoleAbonnement
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.WriteLine("Bestelgegevens");
		Console.WriteLine("==============");
		
        Console.Write("naam klant: ");
		string naam = Console.ReadLine();
		Console.Write("aantal toegangsbeurten: ");
		int beurten = int.Parse(Console.ReadLine());
		Console.Write("prijs (bv. 122,5): ");
		double prijs = double.Parse(Console.ReadLine());
		Console.Write("badkledij inbegrepen (typ true of false): ");
		bool badkledij = bool.Parse(Console.ReadLine());
		Console.Write("geslacht (druk 'm' of 'v'): ");
		char geslacht = Console.ReadKey().KeyChar;
		Console.WriteLine();
		
		Random rnd = new Random();
		int deel1 = rnd.Next(0, 1000);
		int deel2 = rnd.Next(0, 10000);
		int deel3 = rnd.Next(0, 100);
		string kaartnummer = $"{deel1}-{deel2}-{deel3}";
		
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine($@"
Samenvatting
============
houder: {naam}
geslacht: {geslacht}
prijs: {prijs}
aantal beurten: {beurten}
incl. badkledij: {badkledij}
kaartnummer: {kaartnummer}
"); 
		Console.ResetColor();
		Console.WriteLine("druk op een toets om verder te gaan...");
		Console.ReadKey(); 
		
      }
   }
}

	 using System;

namespace ConsoleBuffet
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(@"
WELKOM IN HET BUFFETRESTAURANT
==============================");
        Console.WriteLine();
		Console.WriteLine(@"
Alles is à volonté en dranken zijn inbegrepen!
!!Promotie!! vandaag ronden we het totaalbedrag af naar beneden!");
        Console.ResetColor();
		Console.WriteLine();
		
		const double prijs_seizoen = 18.5;
		const double prijs_dessert = 7.95;
		const double prijs_kids = 8.95; 
		
		Console.Write("Aantal seizoensbuffets (€18.5): ");
		int aantalSeizoen = Convert.ToInt32(Console.ReadLine());
		Console.Write("Aantal dessertenbuffets (€7.95): ");
		int aantalDessert = Convert.ToInt32(Console.ReadLine());
		Console.Write("Aantal kids menus (€8.95): ");
		int aantalKids = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		
		Console.Write("Fooi (0 indien geen): ");
		double fooi = Convert.ToDouble(Console.ReadLine());
		double totaal = (aantalSeizoen * prijs_seizoen) + (aantalDessert * prijs_dessert) + (aantalKids * prijs_kids) + fooi;
        Console.WriteLine($"totaal te betalen: €{totaal}");
		double totaalDouble = Convert.ToDouble(totaal);
		totaalDouble = Math.Floor(totaalDouble);
        Console.WriteLine($"Afgerond naar beneden : €{totaalDouble}");
		Console.WriteLine();
		
        Console.Write("Cash betaald: ");
        double betaald = Convert.ToDouble(Console.ReadLine());
        double terug = betaald - totaalDouble;
	    Console.WriteLine("U krijgt terug: ");
		
		if ((terug/50)>1)
		{
			int vijftig = Convert.ToInt32(Math.Floor(terug / 50));
			Console.WriteLine($"- {vijftig} briefjes(s) van 50");
			terug = terug % 50;
		}
		else
		{
			Console.WriteLine("- 0 briefjes(s) van 50");
		}
		
		if ((terug/20)>1)
		{
			int vijftig = Convert.ToInt32(Math.Floor(terug / 20));
			Console.WriteLine($"- {vijftig} briefjes(s) van 20");
			terug = terug % 20;
		}
		else
		{
			Console.WriteLine("- 0 briefjes(s) van 20");
		}
		
		if ((terug/20)>1)
		{
			int vijftig = Convert.ToInt32(Math.Floor(terug / 20));
			Console.WriteLine($"- {vijftig} briefjes(s) van 20");
			terug = terug % 20;
		}
		else
		{
			Console.WriteLine("- 0 briefjes(s) van 20");
		}
		
		if ((terug/10)>1)
		{
			int vijftig = Convert.ToInt32(Math.Floor(terug / 10));
			Console.WriteLine($"- {vijftig} briefjes(s) van 10");
			terug = terug % 10;
		}
		else
		{
			Console.WriteLine("- 0 briefjes(s) van 10");
		}
		if ((terug/5)>1)
		{
			int vijftig = Convert.ToInt32(Math.Floor(terug / 5));
			Console.WriteLine($"- {vijftig} briefjes(s) van 5");
			terug = terug % 5;
		}
		else
		{
			Console.WriteLine("- 0 briefjes(s) van 5");
		}
		if ((terug/2)>1)
		{
			int vijftig = Convert.ToInt32(Math.Floor(terug / 2));
			Console.WriteLine($"- {vijftig} briefjes(s) van 2");
			terug = terug % 2;
		}
		else
		{
			Console.WriteLine("- 0 briefjes(s) van 2");
		}
		if ((terug/1)>1)
		{
			int vijftig = Convert.ToInt32(Math.Floor(terug / 1));
			Console.WriteLine($"- {vijftig} briefjes(s) van 1");
			terug = terug % 1;
		}
		else
		{
			Console.WriteLine("- 0 briefjes(s) van 1");
		}	
      }
   }
}

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
		
		Console.WriteLine("Fooi (0 indien geen): ");
		double fooi = Convert.ToDouble(Console.ReadLine());
		
		double totaal = (aantalSeizoen * prijs_seizoen) + (aantalDessert * prijs_dessert) + (aantalKids * prijs_kids) + fooi;
        totaal = Math.Round(totaal, 2);
        double afgerond = Math.Floor(totaal);
		
        Console.WriteLine($"Totaal ta betalen : €{totaal}");	
        Console.WriteLine($"Afgerond naar beneden : €{afgerond}");	
        Console.Write("Cash betaald: ");
		
        double betaald = Convert.ToDouble(Console.ReadLine());
        double terug = betaald - afgerond;
	    Console.WriteLine($"U krijgt terug: €{terug}");
		int[] biljetten = { 50, 20, 10, 5, 2, 1 };
		int resterend = (int)terug;
		
		foreach (int biljet in biljetten)
		{
		int aantal = resterend / biljet;
		resterend %= biljet; 
		Console.WriteLine($"- {aantal} briefje(s)/stuk(ken) van {biljet}");
		}
      }
   }
}

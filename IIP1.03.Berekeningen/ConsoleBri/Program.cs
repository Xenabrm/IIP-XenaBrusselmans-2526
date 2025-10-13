using System;

namespace Template
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine(@"
BRI CALCULATOR 🏋️
================= ");
		int taille = 88;
		int lengte = 192;
		const double basis = 364.2;
		const double factor = 365.5;
		const double ondergrens = 3.41;
		const double bovengrens = 4.44;
		
		double straal = taille / (2 * Math.PI);
		double halflengte = lengte / 2.0;
		double binnen = 1 - Math.Pow(straal, 2) / Math.Pow(halflengte, 2);
		if (binnen < 0) binnen = 0;
		
		double bri = basis - factor * Math.Sqrt(binnen);
		bri = Math.Round(bri, 1);
		
		Console.WriteLine($"Taille (in cm): {taille}");
		Console.WriteLine($"Lengte (in cm): {lengte}");
		
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Je BRI bedraagt: {bri}");
		Console.ResetColor();
		
		Console.Write("Een BRI tussen");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write($" {ondergrens} en {bovengrens} ");
		Console.ResetColor();
		Console.WriteLine("is normaal.");
      }
   }
}

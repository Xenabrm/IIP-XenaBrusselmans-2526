using System;

namespace ConsoleBri
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine(@"
BRI CALCULATOR 🏋️
================= ");
        const double basis = 364.2;
		const double factor = 365.5;
		const double ondergrens = 3.41;
		const double bovengrens = 4.44;
        Console.WriteLine();
		Console.Write("Taille (in cm): ");
		double size = Convert.ToInt32(Console.ReadLine());
		Console.Write("Lengte (in cm): ");
		double length = Convert.ToInt32(Console.ReadLine());
		
		double two = Math.Pow(size/(Math.PI*length), 2);
		double three = Math.Sqrt(1-two);
		double BRI = basis - (factor * three);
		
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Je BRI bedraagt: {BRI:F1}");
		Console.ResetColor();
		Console.Write("Een BRI tussen");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write($" {ondergrens} en {bovengrens} ");
		Console.ResetColor();
		Console.WriteLine("is normaal.");
      }
   }
}

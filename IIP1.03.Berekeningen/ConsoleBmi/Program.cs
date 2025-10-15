using System;

namespace ConsoleBmi
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("BMI CALCULATOR");
        Console.WriteLine("==============");
		Console.Write("Lengte (in cm): ");
		int lengte = Convert.ToInt32(Console.ReadLine());
		Console.Write("Gewicht (in kg): ");
		int gewicht = Convert.ToInt32(Console.ReadLine());
		double lengteMeter = lengte / 100.0;
		double BMI = gewicht / (lengteMeter * lengteMeter);
		BMI = Math.Round(BMI, 1);
		Console.WriteLine($"Je BMI bedraagt: {BMI}");
      }
   }
}

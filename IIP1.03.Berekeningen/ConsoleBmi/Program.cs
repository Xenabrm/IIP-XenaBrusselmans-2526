using System;

namespace ConsoleBmi
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine(@" 
BMI CALCULATOR
==============");
		int lengte = 178;
		int gewicht = 65;
		double lengteMeter = Convert.ToDouble(lengte) / 100;
		double quotient = gewicht / Math.Pow(lengteMeter, 2);
		quotient = Math.Round(quotient, 1);
		Console.WriteLine("Lengte (in cm): " + lengte);
		Console.WriteLine("Gewicht (in kg): " + gewicht);
		Console.WriteLine("Je BMI bedraagt: " + quotient);
      }
   }
}

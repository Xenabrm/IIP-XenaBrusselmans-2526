using System;
using System.Globalization;

namespace ConsoleContactCard
{
   class Program
   {
      static void Main(string[] args)
      {
		string naam = "Bobby peru";
		bool gehuwd = false;
		string telefoon = "0486/33.22.19";
		int leeftijd= 25;
		decimal salaris = 2500.00m;
		char geslacht = 'm';
		decimal lengte = 1.75m;
		var be = new CultureInfo("nl-BE");
		
		Console.WriteLine($@"
----------------
*
* Naam: {naam}
* Gehuwd: {gehuwd}
* Telefoon: {telefoon}
* leeftijd: {leeftijd} jaar
* Salaris: {salaris.ToString("C",be)} per maand
* Geslacht: {geslacht}
* Lengte: {lengte:F2}m
*
----------------
druk op de toets om verder te gaan...");
        
		Console.ReadKey();
      }
   }
}

using System;
using System.Globalization;

namespace ConsoleContactCard
{
   class Program
   {
      static void Main(string[] args)
      {
		   
        string naam = "Bobby Peru";
		bool gehuwd = false;
		string telefoon = "0486/33.22.19";
		int leeftijd = 25;
		decimal salaris = 2500.00m;
		char geslacht = 'm';
		double lengte = 1.75;
		string info = $@"
----------------
*
* Naam: {naam}
* Gehuwd: {(gehuwd ? "ja" : "nee")}
* Telefoon: {telefoon}
* Leeftijd: {leeftijd} jaar
* Salaris: € {salaris} per maand
* Geslacht: {geslacht}
* Lengte: {lengte:F2}m 
*
----------------";
		
		Console.WriteLine(info);
		Console.WriteLine("druk op de toets om verder te gaan...");
		Console.ReadKey();	
      }
   }
}

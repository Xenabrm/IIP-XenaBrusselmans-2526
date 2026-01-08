/*Schrijf een console-applicatie die punten op 100 inleest.
* Blijf punten vragen tot de gebruiker ENTER indrukt.

* De ingevoerde punten worden opgeslagen in een lijst.
* Vervolgens moet het programma:

* het aantal ingevoerde punten bepalen

* het gemiddelde van de punten berekenen

* het hoogste en laagste punt bepalen

* het aantal onvoldoendes (punten lager dan 50) tellen

* ️ Enkel geldige gehele getallen tussen 0 en 100 zijn toegestaan!
*/

using System;
using System.Collections.Generic;

namespace ConsolePuntenAnalyse
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("PUNTEN ANALYSE");
		Console.WriteLine("==============");
		
		List<int> punten = LeesPunten();
		
		if (punten.Count == 0)
		{
			Console.WriteLine("\nGeen punten ingevoerd.");
			Console.WriteLine("\nBedankt en tot ziens.");
			return;
		}
		
		Console.WriteLine($"\nAantal punten: {punten.Count}");
		Console.WriteLine($"Gemiddelde: {BerekenGemiddelde(punten)}");
        Console.WriteLine($"Hoogste punt: {BepaalHoogste(punten)}");
		Console.WriteLine($"Laagste punt: {BepaalLaagste(punten)}");
		Console.WriteLine($"Onvoldoendes (<50): {TelOnvoldoendes(punten)}");
		
		Console.WriteLine("\nBedankt en tot ziens.");	
      }
	  
	  static List<int> LeesPunten()
	  {
		  List<int> lijst = new List<int>();
		  bool verder = true;
		  
		  while (verder)
		  {
			  Console.Write("Geef een punt (0-100) (ENTER om te stoppen): ");
			  string input = Console.ReadLine();
			  
			  if (string.IsNullOrWhiteSpace(input))
			  {
				  verder = false;
			  }
			  else
			  {
				  bool geldig = true;
				  int punt = 0;
				  
				  for (int i = 0; i < input.Length; i++)
				  {
					  char c = input[i];
					  
					  if (c < '0' || c > '9')
					  {
						  geldig = false;
					  }
					  else
					  {
						  punt = punt * 10 + (c -'0');
					  }
				  }
				  
				  if (!geldig || punt < 0 || punt > 100)
				  {
					  Console.WriteLine("Ongeldige invoer.");
				  }
				  
				  else
				  {
					  lijst.Add(punt);
				  }
			  }
		  }
		  
		  return lijst;
	  }
	  
	  static double BerekenGemiddelde(List<int> punten)
	  {
		  int som = 0;
		  for (int i = 0; i < punten.Count; i++)
			  som += punten[i];
		  
		  return (double)som / punten.Count;
	  }
	  
	  static int BepaalHoogste(List<int> punten)
	  {
		  int max = punten[0];
		  for(int i = 1; i < punten.Count; i++)
			  if (punten[i] > max) max = punten[i];
		  
		  return max;
	  }
	  
	  static int BepaalLaagste(List<int> punten)
	  {
		   int min = punten[0];
		   for (int i = 1; i < punten.Count; i++)
			  if (punten[i] < min) min = punten[i];
		  
		  return min;
	  }
	  
	  static int TelOnvoldoendes(List<int> punten)
	  {
		  int count = 0;
		  for (int i = 0; i <punten.Count; i++)
			  if (punten[i] < 50) count++;
		  
		  return count;
	  }  
   }
}

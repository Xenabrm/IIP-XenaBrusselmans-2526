using System;

namespace ConsoleNamenZoeken
{
   class Program
   {
      static void Main(string[] args)
      {
        string[] namen =
		{
			"Elias", "Fatima", "Noah", "Aisha", "Liam", 
			"Sofia", "Kenji", "Mila", "Omar", "Yara"
		};
		
		while (true)
		{
			ToonMenu();
			
			Console.Write("Maak een keuze: ");
			string keuze = Console.ReadLine();
			
			Console.WriteLine();
			
			if (keuze == "a")
			{
				Console.Write("Naam: ");
				string naamInput = Console.ReadLine();
				
				if (NaamBestaat(namen, naamInput))
				{
					Console.WriteLine($"'{naamInput}' komt voor in de lijst");
				}
				else
				{
					Console.WriteLine($" '{naamInput}' komt niet in de lijst");
				}
			}
			else if (keuze == "b")
			{
				Console.Write("Naam: ");
				string naamInput = Console.ReadLine();
				
				int functie = ZoekVolgnummer(namen, naamInput);
				
				if (functie == 0)
				{
					Console.WriteLine($"'{naamInput}' is niet gevonden");
				}
				else
				{
					Console.WriteLine($"'{naamInput}' is gevonden op positie {functie}");
				}
			}
			else if (keuze == "c")
			{
				Console.Write("Zoekwoord: ");
				string woord = Console.ReadLine();
				
				string gevonden = ZoekOpWoord(namen, woord);
				if (gevonden == null)
				{
					Console.WriteLine($"geen naam gevonden voor '{woord}'");
				}
				else
				{
				Console.WriteLine($"'{gevonden}' gevonden voor '{woord}'");
				}
			}
			else if (keuze == "d")
			{
				Console.Write("Lengte: ");
				int lengte = Convert.ToInt32(Console.ReadLine());
				
				string gevonden = ZoekOpLengte(namen, lengte);
				if (gevonden == null)
				{
					Console.WriteLine($"geen naam gevonden met {lengte}");
				}
				else
				{
					Console.WriteLine($"naam met {lengte}: {gevonden}");
				}
			}
			else if (keuze == "e")
			{
				Console.WriteLine("Afsluiten");
		        return;
			}
			
			Console.WriteLine();
		}
      }
	  
	  static void ToonMenu()
	  {
		  Console.WriteLine(@"
--- Menu ---
a. Constroleer of naam bestaat
b. Zoek volgnummer van naam
c. Zoek naam op woord
d. Zoek naam op lengte
e. Afsluiten");

      }
	  static bool NaamBestaat(string[] namen, string naam)
	  {
		  foreach (string n in namen)
		  {
			  if (n == naam) return true;
		  }
		  
		  return false;
	  }
	  
	  static int ZoekVolgnummer(string[] namen, string naam)
	  {
		  for (int i = 0; i < namen.Length; i++)
		  {
			  if (namen[i] == naam) return i + 1;
		  }
		  
		  return 0;
	  }
	  
	  static string ZoekOpWoord(string[] namen, string woord)
	  {
		  foreach (string n in namen)
		  {
			  if (n.Contains(woord)) return n;
		  }
		  
		  return null;
	  }
	  
	  static string ZoekOpLengte(string[] namen, int lengte)
	  {
		  foreach (string n in namen)
		  {
			  if (n.Length == lengte) return n;
		  }
			  
		  return null;
	  }
   }
}

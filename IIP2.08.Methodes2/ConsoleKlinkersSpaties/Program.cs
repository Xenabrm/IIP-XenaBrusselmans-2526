using System;

namespace ConsoleKlinkerSpaties 
{
   class Program
   {
      static void Main()
      {
        Console.Write("Geef een tekst: ");
		string tekst = Console.ReadLine();
	    
		int aantalklinkers = AantalKlinkers(tekst);
		int aantalSpaties = AantalSpaties(tekst);
		string geheim = NaamGeheimschrift(tekst);
		
		Console.WriteLine($"deze tekst bevat {aantalklinkers} klinkers en {aantalSpaties} spaties");
		Console.WriteLine($"in geheimschrift: {geheim}");
      }
	  
	  static int AantalKlinkers(string input)
	  {
		  int count = 0;
		  foreach (char c in input)
		  {
			  char lower = (c >= 'A' && c <='Z') ? (char)(c + 32) : c;
			  if (lower == 'a' || lower == 'e' ||  lower == 'i' ||  lower == 'o' ||  lower == 'u')
			  {
				  count++;
			  }
		  }
		  
		  return count;
		  
	  }
	  
	  static int AantalSpaties(string input)
	  {
		  int count = 0;
		  foreach (char c in input)
		  {
			  if (c == ' ')
			  {
				count++;
			  }
		  }
		  return count;
	  }
	  
	  static string NaamGeheimschrift(string input)
	  {
		  string output = "";
		  foreach (char c in input)
		  {
			  if (c == ' ')
			  {
				  output += c;
			  }
			  else
			  {
				  int code = (int) c;
				  code++;
				  output += (char)code;
			  }
          }
          return output;
      }		  
   }
}

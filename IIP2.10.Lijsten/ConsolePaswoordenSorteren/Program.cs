using System;
using System.Collections.Generic;

namespace ConsolepaswoordenSoorten
{
   class Program
   {
      static void Main(string[] args)
      {
        string[] paswoorden =
		{
			"klepetoe",
			"test",
			"Azerty123",
			"rogier@work",
			"password",
			"MisterNastry12",
			"pwnz0red",
		};
		
		List<string> okLijst = new List<string>();
		List<string> nietOkLijst = new List<string>();
		
		Console.WriteLine("Alle paswoorden: ");
		for (int i = 0; i < paswoorden.Length; i++)
		{
			Console.WriteLine($"{i + 1}. {paswoorden[i]}");
		}
		Console.WriteLine();
		foreach (string pw in paswoorden)
		{
			if (IsCorrectPaswoord(pw))
			{
				okLijst.Add(pw);  
			}
			
			else
			{
				nietOkLijst.Add(pw);
			}
		}
		
		Console.WriteLine("Ok: " + string.Join(", ", okLijst));
		Console.WriteLine("Niet ok: " + string.Join(", ", nietOkLijst));
      }
	  
	  static bool IsCorrectPaswoord(string paswoord)
	  {
		  
		  if (paswoord.Length < 8)
		      return false;
		  
          if (paswoord.Contains("@"))
		     return false;

		  if (paswoord == "12345678" ||
		      paswoord == "password" ||
			  paswoord == "Azerty123")
		      return false;
		  
		  return true;
	  }
   }
}

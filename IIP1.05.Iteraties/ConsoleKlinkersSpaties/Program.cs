using System;

namespace ConsoleKlinkersSpaties
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.Write("Geef een tekst: ");
		string tekst = Console.ReadLine();
		
		int aantalKlinkers = 0;
		int aantalSpaties = 0;
		string geheimSchrift = "";
		
		foreach (char c in tekst)
		{
			if ( c == 'a' | c == 'e' | c == 'i' | c == 'o' | c == 'u' ||
			     c == 'A' | c == 'E' | c == 'I' | c == 'O' | c == 'U')
		    {
				aantalKlinkers++;
			}
			if ( c == ' ')
			{
				aantalSpaties++;
			}
			
			char nieuweLetter = c;
			if (c != ' ')
			{
				nieuweLetter = (char)(c + 1);
			}
			
			geheimSchrift += nieuweLetter;
		}
		
		Console.WriteLine($"deze tekst bevat {aantalKlinkers} klinkers en {aantalSpaties} spaties");
		Console.WriteLine($"in geheimschrift: {geheimSchrift}");
		Console.ReadKey();
	  }
   }
}
		    

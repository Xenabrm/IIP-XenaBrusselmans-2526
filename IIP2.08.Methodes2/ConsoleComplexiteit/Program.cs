using System;

namespace ConsoleComplexiteit
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.Write("Geef een woord (enter om te stoppen): ");
		string woord = Console.ReadLine(); 
		
		if (woord == "")
		{
			Console.WriteLine();
			Console.WriteLine("Bedankt en tot ziens.");
			
			return;
	    }
		
		int aantalKarakters = woord.Length;
		int aantalLettergrepen = AantalLettergrepen(woord);
		double complexiteit = Complexiteit(woord);
		
		Console.WriteLine($"aantal karakters: {aantalKarakters}");
		Console.WriteLine($"aantal lettergrepen: {aantalLettergrepen}");
		Console.WriteLine($"complexiteit; {complexiteit:0.0}");
		Console.WriteLine();
	 
      }
	  static int AantalLettergrepen(string woord)
	  {
		  int count = 0;
		  bool wasGeenKlinker = true;
		  
		  foreach (char c in woord)
		  {
			  bool welKlinker = IsKlinker(c);
			  
			  if (welKlinker && wasGeenKlinker)
			  {
				  count++;
			  }
			      wasGeenKlinker = !welKlinker;
		  }
		  
		  return count;  
	  }
	  
	  static bool IsKlinker(char c)
	  {
		  char lower = char.ToLower(c);
		  return lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u';
	  }
	  
	  static double Complexiteit(string woord)
	  {
		  int letters = woord.Length;
		  int lettergrepen = AantalLettergrepen(woord);
		  
		  double score = letters / 3.0 + lettergrepen;
		  
		  bool heeftQ = false;
		  bool heeftX = false;
		  bool heeftY = false;
		  
		  foreach (char c in woord)
		  {
			  char lower = char.ToLower(c);
			  
			  if (lower == 'q') heeftQ = true;
			  if (lower == 'x') heeftX = true;
			  if (lower == 'y') heeftY = true;
		  }
		  
		  if (heeftQ) score += 1.0;
		  if (heeftX) score += 1.0;
		  if (heeftY) score += 0.5;
		  
			  
		  return score;
		  
	  }
   }
}

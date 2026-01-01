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
	    }
		else
		{
			int aantalKarakters = woord.Length;
			int aantalLettergrepen = AantalLettergrepen(woord);
			double complexiteit = Complexiteit(woord);
			
			Console.WriteLine($"aantal karakters: {aantalKarakters}");
			Console.WriteLine($"aantal lettergrepen: {aantalLettergrepen}");
			Console.WriteLine($"complexiteit; {complexiteit:0.0}");
			Console.WriteLine();
	    }
      }
	  static int AantalLettergrepen(string woord)
	  {
		  int count = 0;
		  bool wasgeenklinker = true;
		  
		  foreach (char c in woord);
		  {
			  bool welklinker = isklinker(c);
			  
			  if (welklinker && wasgeenklinker)
			  {
				  count++;
			      wasgeenklinker = !welklinker;
			  }
			  
			  return count;
		  }
	  }
	  
	  static double Complexiteit(string woord)
	  {
		  int letters = woord.Length;
		  int lettergrepen = AantalLettergrepen(woord);
		  
		  double score = letters / 3 + lettergrepen;
		  
		  bool heeftQ = false;
		  bool heeftX = false;
		  bool heeftY = false;
		  
		  foreach (char c in woord)
		  {
			  char lower = c;
			  if (c >= 'A' && c <= 'Z')
			  {
				  lower = (char)(c + 32);
			  }
			  
			  if (lower == 'q') heeftQ = true;
			  if (lower == 'x') heeftX = true;
			  if (lower == 'y') heeftY = true;
			  
			  return lower;
		  }
	  }
   }
}

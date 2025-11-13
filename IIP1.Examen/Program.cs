using System;

namespace SNOEPMACHINE
{
   class Program
   {
      static void Main(string[] args)
      {
		char keuze;
		int drank = 2.00;
        int snoep = 1.50;
		double munt = 0;
		bool saldo = false;
		bool antwoord = false;
		string emoji = "🪙";
        
        do
        {
	      Console.ClearLine();
          Console.WriteLine(@"SNOEPMACHINE 🍭🥤
		
a. geld inwerpen
b. drank kopen (2,00 euro)
c. snoep kopen (1,50 euro)
d. stoppen

Huidig salde: 0 euro
Maak je keuze: ");
          
		  keuze = char.ToLower(Console.ReadKey(true).KeyChar);
		  Console.WriteLine();
		  
		  switch (keuze)
		  {
			  case 'a':
			  Console.Write("Inworp: ");
			  double Inworp = Convert.Todouble(Console.ReadLine());
			  
			  while (Inworp == emoji)
			  {
				  Console.WriteLine($"Huidig saldo : ({Inworp} + {emoji})"); 
                  saldo2 = Inworp + emoji;				  
                  antwoord = true; 				  
			  }
		      while (Inworp != 0.5);
			  {
				Console.WriteLine("Alleen muntstukken van 0.5 euro of veelvouden daarvan zijn toegelaten.");
                antwoord = false;				
			  }
              Console.ReadKey(true);
			  break;
			  
			  case 'b' && 'c':
			  
			  if (saldo2)
			  {
				  Console.WriteLine("Je drankje komt eraan!");
				  Saldo = true;
			  }
			  else
			  {
				  Console.WriteLine("Je saldo is te laag; gelieve nog geld in te werpen");
			  }
			  Console.ReadKey(true);
			  break;
			  
			  case 'd':
			  Console.WriteLine($"Je krijgt {saldo2} euro terug.");
			  Console.ReadKey(true);
			  break;
			  default:
			  Console.WriteLine("is geen geldige keuze, druk op een toets om verder te gaan...");
			  Console.ReadKey(true);
			  break;
		  }	  
		}
        while		
           Console.ReadKey();		
      }
   }
}

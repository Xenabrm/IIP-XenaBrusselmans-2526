using System;
using System.Text;
using System.Globalization;

namespace ConsoleHerhaling
{
   class Program
   {
      static void Main(string[] args)
      {
		char keuze;
		int aantalOuder = 0;
		int aantalKind = 0;
		double ouder = 19.90;
		double kind = 12.50;
		string emoji = "🎫";
		bool running = true;
		var be = new CultureInfo("nl-BE");
		
		while (running)
		{
			
		    Console.Clear();
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.Write(@"Welkom bij de ticketshop voor ""Circus Stromboli""
(a) Tickets toevoegen
(b) Winkelmandje tonen
(c) Winkelmandje wissen
(q) Bestelling afronden
      
Je keuze: ");

		  keuze = char.ToLower(Console.ReadKey().KeyChar);
		  Console.WriteLine();
		  
		  switch (keuze)
		  {
			case 'a':
			   Console.Write("Volwassenen: ");
			   aantalOuder = Convert.ToInt32(Console.ReadLine());
			   Console.Write("Kinderen: ");
			   aantalKind = Convert.ToInt32(Console.ReadLine());
			   Console.WriteLine($"Er zijn tickets voor {aantalOuder} volwassenen en {aantalKind} kinderen toegevoegd aan je winkelmandje");
			   Console.WriteLine("\n...druk een toets om verder te gaan.");
			   Console.ReadKey(true);
			   break;

			case 'b':
			   Console.Write($"Volwassenen: ");
			   for(int i= 0; i < aantalOuder; i++) 
			   {
				  Console.Write(emoji + " ");
			   }
			   Console.WriteLine();
			   
			   Console.Write("Kinderen: ");
			   for(int i= 0; i < aantalKind; i++)
			   {
				   Console.Write(emoji + " ");
			   }
			   Console.WriteLine();
			   
			   Console.WriteLine("\n...druk een toets om verder te gaan."); 
			   Console.ReadKey(true);
			   break; 
			   
			case 'c':
			   ouder = 0;
			   kind = 0;
			   Console.WriteLine("Winkelmandje is gewist.");
			   Console.WriteLine("\n...druk een toets om verder te gaan.");
			   Console.ReadKey(true);
			   break;
			   
			case 'q':
			   double totaal = (aantalOuder * ouder) + (aantalKind * kind);
			   Console.WriteLine($"Totaalprijs: {totaal.ToString("C",be) }");
			   Console.WriteLine();
			   
			   Console.Write("Ben je jarig vandaag (j/n)? ");
			   bool jarig = Console.ReadLine().ToLower() == "j";
			   
			   int percent = 0;
			   if (jarig)
			   {
				   percent = new Random().Next(5, 11);
				   Console.WriteLine($"Gefeliciteerd! Je krijgt {percent}% korting op je totaalprijs.");
			   }
			   else
			   {
				   Console.WriteLine("\nVandaag geen korting");
			   }   
			   double teBetalen = Math.Round(totaal * (1 - percent / 100.0),2);
			   Console.WriteLine($"\nTe betalen bedrag: {teBetalen:C2}");
			   
		       int punten = (int)(teBetalen / 10);
			   Console.WriteLine($"\nJe hebt {punten} bonuspunten verzameld");
			   Console.WriteLine("Tot ziens!");
			   
			   Console.ReadKey(true);
			   running = false;
			   break;  
               default:	
               Console.WriteLine("Incorrect"); 
			   break;			   
		  }  
		  Console.ReadKey();
		}
      }
   }
}

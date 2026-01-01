using System;

namespace ConsoleAtm
{
   class Program
   {
      static void Main(string[] args)
      {
        string header = @"
Bankautomaat
------------";
       
	   const int MAX_AFHALING = 500;
	   int saldo = 1000;
	    
	  Console.WriteLine(header);
	  Console.WriteLine($"huidige saldo: {saldo}");
	  Console.WriteLine();
	  Console.WriteLine("a. afhaling");
	  Console.WriteLine("b. storting");
	  Console.WriteLine("c. stoppen");
	  Console.WriteLine();
	  
	  Console.Write("je keuze: ");
	  char keuze = Console.ReadKey(true).KeyChar;
	  Console.WriteLine();
	  
	  switch (keuze ='a')
	  {
	    case
		  Console.WriteLine("Welk bedrag wil je afhalen: ");
		  string invoer = Console.ReadLine();
		  int bedrag = Convert.ToInt32(invoer);
		  
		  if (bedrag <=0)
		  {
			   Console.WriteLine("Fout: bedrag moet positief zijn");
		  }
		  else if (bedrag > MAX_AFHALING || saldo - bedrag < 0)
		  {
			   Console.WriteLine("Fout: je kan maximaal {MAX_AFHALEN} afhalen of je saldo is te laag");
		  }
		  else if (bedrag % 10 != 0 || bedrag == 10 || bedrag == 30)
		  { 
				Console.WriteLine("Fout: enkel briefjes van 20 en 50 zijn mogelijk"); 
		  }
		  else
		  {
				saldo -= bedrag;
				Console.WriteLine($"Afhalen ok - het nieuw saldo is € {saldo}");
		  }
		}
        else if (keuze ='b')
        {    
		   Console.Write("Welke bedrag wil je storten: ");
		   string invoer = Console.ReadLine();
           int stort = Convert.ToInt32(invoer);
           
           saldo += stort;
           Console.WriteLine($"Storting ok - het nieuw saldo is € {saldo}");
        }
        else if (keuze ='c')
        {
            Console.WriteLine("Bedankt en tot ziens!");
        }
        else
        {
             Console.WriteLine("Ongeldige keuze");

	     }
       
	  
      }
	  
   }
}

using System;

namespace ConsoleAtm
{
   class Program
   {
	  static readonly CultureInfo BE = new CultureInfo("nl-BE");
      static void Main(string[] args)
      {
        string header = @"
Bankautomaat
------------";
       
	   const int MAX_AFHALING = 600;
	   const decimal START_SALDO = 1000;
	   
	   Console.OutputEncoding = System.Text.Encoding.UTF8;
	   Console.WriteLine(hearder);
	   Console.WriteLine($"huidige saldo: {saldo.ToString("C", BE)}");
	   Console.WriteLine();
	   
	  Console.WriteLine("a. afhaling");
	  Console.WriteLine("b. storting");
	  Console.WriteLine("c. stoppen");
	  Console.WriteLine();
	  
	  Console.Write("je keuze: ");
	  char keuze = 
      }
   }
}

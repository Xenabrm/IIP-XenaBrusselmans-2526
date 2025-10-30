using System;

namespace ConsoleLancering
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("Hoeveel seconden tot lancering? ");
		int seconden = Convert.ToInt32(Console.ReadLine());
		
	  Console.WriteLine("\nfor-versie");
	  for (int i = seconden; i > 0; i--)
      {
		Console.WriteLine($"{i}...");
	  }
	  Console.WriteLine("Lift off!"); 
	  Console.WriteLine();
	  
	  Console.WriteLine("\ndo-while versie");
	  int j = seconden;
	  do 
	  {
	    Console.WriteLine($"{j}...");
		j--;
	  }
	  while (j > 0);
	  Console.WriteLine("Lift off!");
	  Console.WriteLine();
	  
	  Console.WriteLine("\nwhile versie");
	  int k = seconden;
	  while (k > 0)
	  {
		  Console.WriteLine($"{k}...");
		  k--;
	  }
	  Console.WriteLine("Lift off!");
	  Console.WriteLine();
		
	  } 	 
   }
}

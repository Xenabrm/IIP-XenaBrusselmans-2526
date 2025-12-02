using System;

namespace ConsoleFaculteit
{
   class Program
   {
	  static void Main()
	  {
		  Console.WriteLine("FACULTEIT BEREKENEN");
		  Console.Write("Geef een geheel getal: ");
		  
		  string invoer = Console.ReadLine();
		  int n = Convert.ToInt32(invoer);
		  
		  int fac = Faculteit(n);
		  
		  Console.WriteLine($"De faculteit is {fac}");
		  Console.ReadLine();
	  }
      private static int Faculteit(int n)
      {
        int resultaat = 1;
		
		for (int i = 1; i <= n; i++)
		{
			resultaat *= i;
		}
		
		return resultaat;
      }
   }
}

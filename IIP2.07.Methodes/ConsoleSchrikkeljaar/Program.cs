using System;

namespace ConsoleSchrikkeljaar
{
   class Program
   {
      static void Main()
      {
        Console.WriteLine("SCHRIKKELJAAR");
		Console.WriteLine("==============");
		
		int jaar = -1;
		
		while (jaar != 0)
		{
			Console.Write("Geef een jaartal: ");
			jaar = Convert.ToInt32(Console.ReadLine());
			
			if (jaar != 0)
			{
				if (IsSchrikkeljaar(jaar))
				{
					Console.WriteLine($"Het jaar {jaar} is een schrikkeljaar.");
				}
				else
				{
					Console.WriteLine($"Het jaar {jaar} is geen schrikkeljaar.");
				}
			}
		}
		Console.WriteLine();
		Console.WriteLine("Bedankt en tot ziens.");
	  }
	  
	  private static bool IsSchrikkeljaar(int jaar)
	  {
		  if (jaar % 400 == 0)
		  {
			  return true;
		  }
		  if (jaar % 100 == 0)
		  {
			  return false;
		  }
		  if (jaar % 4 == 0)
		  {
			  return true;
		  }
		  
		  return false;
	  }
   }
}

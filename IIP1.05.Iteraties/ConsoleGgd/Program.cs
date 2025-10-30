using System;

namespace ConsoleGgd
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("BEREKEN GROOTST GEMENE DELER");
		Console.WriteLine("=============================");
		
		Console.Write("Getal 1: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Getal 2: ");
		int b = Convert.ToInt32(Console.ReadLine());
		
		//als de twee getallen niet gelijk zijn, herhaal
		do
		{
			if (a > b)
			{
				a = a - b;
			}
			else
			{
				b = b - a;
			}
		}
		while (a != b);
		// a en b zijn gelijk
		Console.WriteLine($"De grootste gemene deler is: {a}");
      }
   }
}

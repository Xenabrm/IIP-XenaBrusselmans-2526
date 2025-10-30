using System;

namespace Template
{
   class Program
   {
      static void Main(string[] args)
      {
        int som = 0;
		string invoer;
		
		do
		{
			Console.Write("Voer een getal in (q om te stoppen): ");
			invoer = Console.ReadLine();
			//niet gelijk aan "q"
			if (invoer != "q")
			{
				int getal = Convert.ToInt32(invoer);
				som += getal;
			}
		}
		while (invoer != "q");
		Console.WriteLine("De som is: " + som);
      }
   }
}

using System;

namespace RadenGrenzen
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine(@"
__________    _____  ________  ___________ _______   
\______   \  /  _  \ \______ \ \_   _____/ \      \  
 |       _/ /  /_\  \ |    |  \ |    __)_  /   |   \ 
 |    |   \/    |    \|    `   \|        \/    |    \
 |____|_  /\____|__  /_______  /_______  /\____|__  /
        \/         \/        \/        \/         \/ ");
		
		Console.Write("Geef twee gehele getallen. \n- getal 1: ");
		int getal1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("- getal 2: ");
		int getal2 = Convert.ToInt32(Console.ReadLine());
		
		if (getal1 > getal2)
		{
			int tmp = getal1;
			getal1 = getal2;
			getal2 = tmp;
		}
		
		Random rnd = new Random();
		int geheimGetal = rnd.Next(getal1, getal2 + 1);
		Console.WriteLine($"Even denken... ja, ik heb een getal tussen {getal1} en {getal2} in mijn hoofd.");
		Console.Write("Doe een gok: ");
		int gok = Convert.ToInt32(Console.ReadLine());
		
		if (gok == geheimGetal)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("JUIST!");
		}
		else
	    {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("FOUT!");
			
			int verschil = Math.Abs(gok - geheimGetal);
			if (verschil <= 2)
			{
				Console.ResetColor();
				Console.WriteLine("Je zat er nochtans niet ver af!");
			}
		
		}
		
		Console.ResetColor();
	  }
   }
}

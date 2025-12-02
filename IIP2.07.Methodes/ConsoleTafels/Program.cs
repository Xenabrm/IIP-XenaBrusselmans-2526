using System;

namespace ConsoleTafels
{
   class Program
   {
      static void Main(string[] args)
      {
        MaakTafel(4, 6);
		Console.WriteLine();
		MaakTafel(2, 5);
		Console.WriteLine();
		MaakTafel(7);
		Console.WriteLine();
		
		int getal = VraagPositiefGetal();
		int lengte = VraagPositiefGetal();
		
		MaakTafel(getal, lengte);
		Console.ReadKey();
      }
	  private static void MaakTafel(int getal, int lengte = 10)
	  {
		  Console.WriteLine($"{getal} x {lengte} tafel: ");
		  for (int i = 1; i <= lengte; i++)
		  {
			  int resultaat = getal * i;
			  Console.WriteLine($"{getal} x {i} = {resultaat}");
		  }
	  }
	  
	  private static int VraagPositiefGetal()
	  {
		  int getal;
		  
		  Console.Write("Geef een positiefgetal: ");
		  getal = Convert.ToInt32(Console.ReadLine());
		  
		  while (getal <= 0)
		  {
			  Console.Write("Het getal moet positief zijn! Geef een getal: ");
			  getal = Convert.ToInt32(Console.ReadLine());
		  }
		  
		  return getal;
	  } 
   }
}

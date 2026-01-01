using System;
using System.Collections.Generic;

namespace ConsoleBergbeklimmen
{
   class Program
   {
      static void Main(string[] args)
      {
        List<int> hoogtes = new List<int>();
		int hoogte;
		
		do
		{
			Console.Write("Voer een hoogtemeting in (in m): ");
			hoogte = Convert.ToInt32(Console.ReadLine());
			
			if (hoogte != 0)
			{
				hoogtes.Add(hoogte);
			}
			
		} while (hoogte != 0);
		
		int[] stijging = BerekenStijgingen(hoogtes);
		
	    Console.WriteLine($"Stijgingen: {string.Join(", ", stijging)} meter");
		Console.WriteLine();
		
		Console.WriteLine($"De hoogste helling is {BerekenSterksteStijgingen(stijging)} meter");
		Console.WriteLine($"De totale stijging is {BerekenTotaleStijgingen(stijging)} meter");
      }
	  
	  static int[] BerekenStijgingen(List<int> hoogtes)
	  {
		  int[] stijgingen = new int[hoogtes.Count - 1];
		  
		  for (int i = 0; i < hoogtes.Count - 1; i++)
		  {
			  stijgingen[i] = hoogtes[i + 1] - hoogtes[i];
		  }
		  
		  return stijgingen;
	  }
   
	   static int BerekenSterksteStijgingen(int[] stijgingen)
	   {
		   int max = stijgingen[0];
		   
		   for (int i = 1; i < stijgingen.Length; i++)
		   {
			   if (stijgingen[i] > max)
				   max = stijgingen[i];
		   }
		   
		   return max;
	   }
	   
	   static int BerekenTotaleStijgingen(int[] stijgingen)
	   {
		   int totaal = 0;
		   
		   foreach (int s in stijgingen)
		   {
			   if (s > 0)
				   totaal += s;
		   }
		   
		   return totaal;
	   }
    }
 
}

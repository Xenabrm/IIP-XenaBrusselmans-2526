using System;

namespace ConsoleTemperatuur
{
   class Program
   {
      static void Main(string[] args)
      {
        int[] dagen = {1,2,3,4,5,6,7};
		double[] temperaturen = new double[dagen.Length];
		
		for (int i = 0; i < dagen.Length; i++)
		{
			Console.Write($"geef de temperatuur op voor de dag {dagen[i]}: "); 
			temperaturen[i] = Convert.ToDouble(Console.ReadLine());
		}
			double som = temperaturen[0];
			double hoogste = temperaturen[0];
			double laagste = temperaturen[0];
			
		for (int i = 1; i < dagen.Length; i++)
	    {	
		   double t = temperaturen[i];
		   som += t;
		   
		   if (t > hoogste)
			   hoogste = t;
		   
		   if (t < laagste)
			   laagste = t;
		}
		
		double gemiddelde = som / dagen.Length;
	    string celcius = "°C";
		
		Console.Write("Temperaturen deze week: ");
		foreach (double t in temperaturen)
		{
			Console.Write($"{t:0.0}{celcius}");
		}
		Console.WriteLine();
		
		
        Console.WriteLine($@"
Gemiddelde temperatuur: {gemiddelde:0.0} {celcius}
Hoogste Temperatuur: {hoogste:0.0} {celcius}
Laagste temperatuur: {laagste:0.0} {celcius}");

        Console.ReadKey();
      }
   }
}

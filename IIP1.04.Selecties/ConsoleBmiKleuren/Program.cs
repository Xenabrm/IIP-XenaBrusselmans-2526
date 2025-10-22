using System;

namespace ConsoleBmiKleuren
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("BMI CALCULATOR");
		Console.WriteLine("==============");
		double lengthCm = ReadDouble("Lengte (in cm): ");
		double gewichtKg = ReadDouble("Gewicht (in kg): ");
		
		double lengteM = lengthCm / 100.0;
		double bmi = gewichtKg / (lengteM * lengteM);
		Console.WriteLine($"Je BMI bedraagt: {bmi:0.0}");
		
		string boodschap;
		ConsoleColor kleur;
		
		if (bmi < 18.5)
	    {
			boodschap = ("Je hebt ondergewicht");
			kleur = ConsoleColor.Yellow;
		}
		else if (bmi < 25.0)
	    {
			boodschap = ("Je gewicht is normaal");
			kleur = ConsoleColor.Green;
		}
		else if (bmi < 30.0)
	    {
			boodschap = ("Je hebt overgewicht");
			kleur = ConsoleColor.DarkYellow;
		}
		else 
	    {
			boodschap = ("Je hebt obesitas");
			kleur = ConsoleColor.Red;
		}
        Console.ForegroundColor = kleur;
        Console.WriteLine(boodschap);
        Console.ResetColor();
	   }
        static double ReadDouble(string message)	
	  {
	     Console.Write(message);
		 string input = Console.ReadLine();
		 double value = Convert.ToDouble(input);
		 return value;  
      }
   }
}

using System;
using System.Globalization;

namespace Bankautomaat
{
   class ConsoleBankautomaat
   {
      static void Main()
      {
		  bool doorgaan = true;
		  var be = new CultureInfo("nl-BE");

		  Console.WriteLine("Bankautomaat");
		  Console.WriteLine("============");
		  Console.Write("huidig saldo: ");
		  double saldo = Convert.ToDouble(Console.ReadLine());

		  while (doorgaan)
		  {

			  Console.WriteLine($"\nHuidige saldo: {saldo.ToString("C",be)}");
			  Console.WriteLine("a. afhaling");
			  Console.WriteLine("b. storting");
			  Console.WriteLine("c. stoppen");

			  Console.Write("\nJe keuze: ");
			  char keuze = char.ToLower(Console.ReadKey().KeyChar);
			  Console.WriteLine();

			  if (keuze == 'a')
			  {
				  Console.Write("Welk bedrag wil je afhalen: ");
				  double bedrag = Convert.ToDouble(Console.ReadLine());

				  if (bedrag % 20 == 0 || bedrag % 50 == 0)
				  {

					  if (bedrag <= saldo)
					  {
						  saldo -= bedrag;
						  Console.WriteLine($"afhaling ok - het nieuw saldo is {saldo.ToString("C",be)}");
					  }
				  }
				  else
				  {
					  Console.WriteLine("fout: enkel briefjes van 20 en 50 zijn mogelijk");
				  }
			  }
			  else if (keuze == 'b')
			  {
				  Console.Write("welk bedrag wil je storten: ");
				  double bedrag = Convert.ToDouble(Console.ReadLine());
				  saldo += bedrag;
				  Console.WriteLine($"storting ok - het nieuw saldo is {saldo.ToString("C",be)}");
			  }
			  else if (keuze == 'c')
			  {
				   doorgaan = false;
			  }
			  else
			  {
				  Console.WriteLine("ongeldige keuze");
			  }
		  }
		  
		  Console.WriteLine("\nbedankt en tot ziens");
	  }
   }
}

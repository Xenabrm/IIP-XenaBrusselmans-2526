using System;
using System.Text;
namespace ConsoleDrankkaart
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.OutputEncoding = Encoding.UTF8;
		
		
        Console.WriteLine(@"====== MENU ======
☕ Koffie:	3€
🍵 Thee:	2€
🥤 Lime:	2€
------------------");
		Console.WriteLine("copyright ©2025");
		Console.WriteLine();
		Console.WriteLine("Het menu staat ook op \"C:\\Dropbox\\MijnCafe\\menu.pdf");
		Console.ReadKey(); 
      }
   }
}

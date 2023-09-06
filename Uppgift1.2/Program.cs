using System;
namespace Uppgift1_2 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(":(");
            Console.WriteLine("Din enhet har stött på ett problem under uppdateringen.");
            Console.WriteLine("Vi har sammanställt en del felinformation och försöker starta om enheten.");
            Console.WriteLine("Om enheten ej lyckas starta så kan en kritisk fil blivit korrupt.");
            Console.WriteLine("Om detta hänt, måste du installera Windows på nytt.");
            Console.ReadKey();
        }
    }
}

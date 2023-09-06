using System;

namespace uppgift_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;//ändrar bagrunden till texten till blå
            Console.Clear();//gör så att bakgrundsfärgen sprids ut över hela fönstret, inte bara brecis bakom texten
            Console.ForegroundColor = ConsoleColor.White;//ändrar textfärgen till vit
            Console.WriteLine("Din dator har kraschat. Det går inte att fixa.");//crashmeddelande
            Console.WriteLine("Vänligen kasta i en industriell masugn.");
        }
    }
}
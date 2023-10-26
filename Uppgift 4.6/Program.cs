using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande!");
            string meddelande = Console.ReadLine();

            Console.WriteLine("Detta meddelande kommer att skrivas ut vertikalt, hur många steg vill du att det ska förskjutas (åt höger");
            int steg = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)
            {
                string karaktärer = meddelande[i].ToString();

                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(karaktärer);
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace Gosen_adventures
{
    class Program
    {
        static void Main(string[] args)
        {
            World w = new World();
            w.Init(4);

            Character theHero = new Character("SuperLink", 100, 10);

            Console.WriteLine(World.Map[theHero.Coordinates[0], theHero.Coordinates[3]].Description);

            string command = string.Empty;
            while (command != "avsluta")
            {
                Console.WriteLine(">");
                command = Console.ReadLine();
            }

            Console.WriteLine("Hej då!");
            Console.ReadLine();
        }
    }
}

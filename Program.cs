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

            Console.WriteLine(World.Map[theHero.Coordinates[0], theHero.Coordinates[0]].Description);
            

            string command = string.Empty;
            while (command != "avsluta")
            {
                command = WaitForUserInput();

                theHero.DoCommand(command);
            }

            Console.WriteLine("Tack för att du spelade, Hej då!");
            Console.ReadLine();
        }
        private static string WaitForUserInput()
        {
            Console.Write(">");
            string command = Console.ReadLine().ToLowerInvariant();

            return command;

        }
    }
}

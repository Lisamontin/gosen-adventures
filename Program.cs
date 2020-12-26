using System;

namespace Gosen_adventures
{
    class Program
    {
        static void Main(string[] args)
        {
            World w = new World();
            w.Init(4);

            Console.WriteLine("Hej hjälte, vad heter du?");
            string playerName = Console.ReadLine();
            
            Console.WriteLine("Hjälp " + playerName + ", vi är i en riktig knipa! En onding har tagit Tigge och låst in honom i en låda. Vi måste hitta nyckeln...");


            Character theHero = new Character(playerName, 100, 10);

            Thing nyckel = new Thing("Nyckel", "Den glänser och glimmar", 2);
        
            theHero.Inventory.Add(nyckel);

            Console.WriteLine(World.Map[theHero.Coordinates[0], theHero.Coordinates[0]].Description);
            Console.Write(theHero.Inventory[0].Name);
            

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

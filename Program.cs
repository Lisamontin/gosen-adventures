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


// planning //

// Finish Game //
// if theHero enters coordinates .. && has the key in the inventory arr, the "chest" is opened and tigge is saved.
// if theHero enters coordinates .. w/o key he will see the "chest" and hear the cries but will be prompted to find the key.

// how to pick up the key.. enter room with key in it. see sth shiny. Pick up the key? y/n

// add other items to pick up.. fiends to defeat
// solve randomized message when hitting walls. 

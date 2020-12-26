
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

public class Movements : Action 
{
  private StringCollection verbs = new StringCollection() {"gå", "spring"};
  public override StringCollection Verbs => verbs; //=> is like "return verbs"

///////////////////////////////////////////////////////////////////////////////////////////////////
//Trying to implement random msg for when player steps out of bounds// 
  public static List<string> boundaryMessages = new List<string> {
    "a",
    "b",
    "c",
    "d"
  };
  // string[] messages = {"Hej", "Hoj", "skoj"};

  private static Random rnd = new Random();
  private static int rndMsg = rnd.Next(boundaryMessages.Count); // from int to string..........

  ////////////////////////////////////////////////////////////////////////////////////////////////

  public override void Execute(Character c, string args)
  {
    string direction = args.Split(' ')[1];

    switch (direction)
    {
      case "framåt":
      if (c.Coordinates[1] < World.WorldSize - 1) 
        {
          c.Coordinates[1]++;
        }
        else
        {
            Console.WriteLine(rndMsg);
        }
        break;
      case "bakåt":
        if (c.Coordinates[1] != 0) {
          c.Coordinates[1]--;
        }
        else
        {
            Console.WriteLine(rndMsg);
        }
        break;
      case "höger":
        if (c.Coordinates[0] < World.WorldSize - 1) 
        {
          c.Coordinates[0]++;
        }
        else
        {
            Console.WriteLine(rndMsg);
        }
        break;
      case "vänster":
        if (c.Coordinates[0] != 0) 
        {
          c.Coordinates[0]--;
        }
        else
        {
            Console.WriteLine(rndMsg);
        }
        break;
        
      default:
        break;
    }
  }
}
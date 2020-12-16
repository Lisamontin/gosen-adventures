using System.Collections.Specialized;

public class Movements : Action 
{
  private StringCollection verbs = new StringCollection() {"gå", "spring"};
  public override StringCollection Verbs => verbs; //=> is like "return verbs"

  public override void Execute(Character c, string args)
  {
    string direction = args.Split(' ')[1];

    switch (direction)
    {
      case "upp":
      if (c.Coordinates[1] < World.WorldSize - 1) 
        {
          c.Coordinates[1]++;
        }
        break;
      case "ner":
        if (c.Coordinates[1] != 0) {
          c.Coordinates[1]--;
        }
        break;
      case "höger":
        if (c.Coordinates[0] < World.WorldSize - 1) 
        {
          c.Coordinates[0]++;
        }
        break;
      case "vänster":
        if (c.Coordinates[0] < World.WorldSize - 1) 
        {
          c.Coordinates[0]--;
        }
        break;
        
      default:
        break;
    }
  }
}
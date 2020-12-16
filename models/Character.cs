using System.Collections.Generic;

public class Character 
{
  public string Name { get; set; }
  public int Health { get; set; }
  public int MaxHealth { get; set; }
  public int Strenght { get; set; }
  public List<Thing> Inventory { get; set; }

  public int[] Coordinates { get; set; }

  public List<Action> actions = new List<Action>() { new Observations() };

  public void DoCommand(string theCommand) 
  {
    foreach (Action item in actions)
    {
        if(item.Verbs.Contains(theCommand)) {
          item.Execute(this);
        }
    }
  }
  public Character(string name, int hp, int str) //Character constructor
  {
    Name = name;
    Health = hp;
    MaxHealth = hp;
    Strenght = str;

    Inventory = new List<Thing>();
    Coordinates = new int[2];
    Coordinates[0] = 0;
    Coordinates[1] = 0;

  }
}
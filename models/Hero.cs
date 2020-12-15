using System.Collections.Generic;

public class Hero 
{
  public string Name { get; set; }
  public int Health { get; set; }
  public int MaxHealth { get; set; }
  public int Strenght { get; set; }
  public List<Thing> Inventory { get; set; }

  public int[] Coordinates { get; set; }
  public Hero(string name, int hp, int str) //Hero constructor
  {
    Name = name;
    Health = hp;
    MaxHealth = hp;
    Strenght = str;

    Inventory = new List<Thing>();
    Coordinates = new int[2];
    Coordinates[0] = 0; //
    Coordinates[1] = 2; // Starting point, the staircase.

  }
}
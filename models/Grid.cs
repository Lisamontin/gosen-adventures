using System.Collections.Generic;

public class Grid {
  public string Description {get; set;}
  public string Name {get; set;}
  public List<Thing> ThingsInGrid {get; set;}

  public Grid(string name, string desc) // grid constructor
  {
    Name = name;
    Description = desc;

    ThingsInGrid = new List<Thing>();
  }
}
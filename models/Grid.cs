using System.Collections.Generic;

public class Environment {
  public string Description {get; set;}
  public string Name {get; set;}
  public List<Thing> ThingsInEnvironment {get; set;}

  public Environment(string name, string desc) // Environment constructor
  {
    Name = name;
    Description = desc;

    ThingsInEnvironment = new List<Thing>();
  }
}
using System;
using System.Collections.Specialized;

public class Observations : Action {
  private StringCollection verbs = new StringCollection() {"titta", "kolla"}; //list with strings "List<string>"

  public override StringCollection Verbs // overrides the property from the base class Action
  { 
    get { return verbs; }
  }

  public override void Execute(Character c, string args) 
  {
    Console.WriteLine(World.Map[c.Coordinates[0], c.Coordinates[1]].Description);
  }
}
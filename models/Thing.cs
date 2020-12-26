public class Thing 
{
  public string Name { get; set; }
  public string Description { get; set; }
  public int Weight { get; set; }
public Thing(string n, string d, int w) 
{
  n = Name;
  d = Description;
  w = Weight;
}
}

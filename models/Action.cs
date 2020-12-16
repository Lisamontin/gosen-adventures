using System.Collections.Specialized;

public abstract class Action {
  public abstract StringCollection Verbs { get; } // string collection = list with texts - List<>
  public abstract void Execute(Character c);
}
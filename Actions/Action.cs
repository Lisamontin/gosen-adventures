using System.Collections.Specialized;

public abstract class Action {
  public abstract StringCollection Verbs { get; } // StringCollection = list with texts - List<string>
  public abstract void Execute(Character c);
}
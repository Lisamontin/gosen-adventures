public class World {
  public static Environment[,] Map; 
  public static int WorldSize;

  public void Init(int size)
  {
    WorldSize = size;

    Map = new Environment[size, size];

    //one object per Environment

  }
}
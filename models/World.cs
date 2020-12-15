public class World {
  public static Grid[,] Map; 
  public static int WorldSize;

  public void Init(int size)
  {
    WorldSize = size;

    Map = new Grid[size, size];
  }
}
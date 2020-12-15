public class World {
  public static Environment[,] Map; 
  public static int WorldSize;

  public void Init(int size)
  {
    WorldSize = size;

    Map = new Environment[size, size];

    //one object per Environment

    Environment e00 = new Environment("Kontor", "Du ser datorer.");
    Environment e01 = new Environment("Toa", "Plums, någon bajsar här.");
    Environment e02 = new Environment("Trapp", "Upp upp upp eller ner ner ner.");
    Environment e03 = new Environment("Kök", "Mmmm det luktar mat.");

    Environment e10 = new Environment("Kontor", "Du ser datorer");
    Environment e11 = new Environment("Hall", "Hmm undrar vart den här korridoren leder?");
    Environment e12 = new Environment("Hall", "Hmm undrar vart den här korridoren leder?");
    Environment e13 = new Environment("Kök", "Mmmm det luktar mat.");

    Environment e20 = new Environment("Sovrum", "zzz");
    Environment e21 = new Environment("Lekrum", "Leksaker överallt");
    Environment e22 = new Environment("Vardagsrum", "Tv, soffa, matta");
    Environment e23 = new Environment("Vardagsrum", "Tv, soffa, matta");

    Environment e30 = new Environment("Sovrum", "zzz");
    Environment e31 = new Environment("Lekrum", "Leksaker överallt");
    Environment e32 = new Environment("Vardagsrum", "Tv, soffa, matta");
    Environment e33 = new Environment("Vardagsrum", "Tv, soffa, matta");

    Map[0, 0] = e00;
    Map[0, 1] = e01;
    Map[0, 2] = e02;
    Map[0, 3] = e03;

    Map[1, 0] = e10;
    Map[1, 1] = e11;
    Map[1, 2] = e12;
    Map[1, 3] = e13;

    Map[2, 0] = e20;
    Map[2, 1] = e21;
    Map[2, 2] = e22;
    Map[2, 3] = e23;

    Map[3, 0] = e30;
    Map[3, 1] = e31;
    Map[3, 2] = e32;
    Map[3, 3] = e33;

  }
}
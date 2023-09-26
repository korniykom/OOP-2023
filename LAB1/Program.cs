namespace MyGame;

public class GameExample {
    static void Main() {
        var playa = new GameAccount("Max");
        playa.WinGame("John", 300);
        playa.LoseGame("Trace", 100);
        System.Console.WriteLine(playa.GetHistory());
        
    }
}
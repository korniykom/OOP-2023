namespace MyGame;

public class GameExample {
    static void Main() {
        var player1 = new GameAccount("Max");
        var player2 = new GameAccount("Frank");
        
        
        player1.WinGame(player2, -100);
        player1.LoseGame(player2, 50);
        player1.WinGame(player2, 20);
       
        player1.WinGame(player2, 550);
        player1.LoseGame(player2, 300);
        player1.WinGame(player2, 150);
        
        
        
        System.Console.WriteLine(player1.GetStats());
        System.Console.WriteLine(player2.GetStats());
   
    }
}
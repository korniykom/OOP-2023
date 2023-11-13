namespace MyGame {
    public class GameExample {
        static void Main() {
            var player1 = new DefaultGameAccount("Player1");
            var player2 = new PremiumGameAccount("Premium");
            var player3 = new DefaultGameAccount("Player3");

            player1.GameResult(player2, 100, "Win");
            player1.GameResult(player2, 200, "Win");

            player2.GameResult(player1, 10, "Win");
            player2.GameResult(player1, 10, "Win");

            player1.GameResult(player3, 40, "Lose");
            player3.GameResult(player2, 100, "Win");

            System.Console.WriteLine(player1.GetStats());
            System.Console.WriteLine(player2.GetStats());
            System.Console.WriteLine(player3.GetStats());
            
        }
    }
}
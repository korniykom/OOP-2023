namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            var regularGameMode = new RegularGameMode();
            var trainingGameMode = new TrainingGameMode();

            GameAccount players[] = new GameAccount[2] ;
            // var player1 = new PremiumAccount("Max");
            // var player2 = new RegularAccount("John");
            players[0] =  new AccountFactory().MakeAccount("premium");

            // regularGameMode.PlayAnGame(player1, player2, 50);
            // regularGameMode.PlayAnGame(player2, player1, 20);
            // regularGameMode.PlayAnGame(player1, player2, 70);
            // regularGameMode.PlayAnGame(player2, player1, 510);
            
            // trainingGameMode.PlayAnGame(player1, player2);
            // trainingGameMode.PlayAnGame(player2, player1);
            // trainingGameMode.PlayAnGame(player1, player2);

            // System.Console.WriteLine(player1.GetStats());
            // System.Console.WriteLine(player2.GetStats());

        }
    }
}
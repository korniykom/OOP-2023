namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            var regularGameMode = new RegularGameMode();
            var trainingGameMode = new TrainingGameMode();

            var player1 = new PremiumAccount("Max");
            var player2 = new RegularAccount("John");

            regularGameMode.PlayAnGame(player1, player2, 50);
            trainingGameMode.PlayAnGame(player1, player2);

            System.Console.WriteLine(player1.GetStats());
            System.Console.WriteLine(player2.GetStats());

        }
    }
}
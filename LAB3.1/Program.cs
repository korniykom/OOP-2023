namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            IAccountService accountService = new AccountService();
            GameAccount player1 = accountService.CreateAccount("premium", "Max");
            GameAccount player2 = accountService.CreateAccount("premium", "John");
            accountService.ReadAccounts();

            IGameService gameService = new GameService();
            GameMode mode1 = gameService.Create("training");
            GameMode mode2 = gameService.Create("regular");
            
            mode2.PlayAnGame(player1, player2, 100);
            mode2.PlayAnGame(player2, player1, 200);
            mode2.PlayAnGame(player2, player1, 50);
            mode2.PlayAnGame(player1, player2, 70);
            
            mode1.PlayAnGame(player2, player1, 100);
            mode1.PlayAnGame(player1, player2, 200);
            mode1.PlayAnGame(player1, player2, 50);
            mode1.PlayAnGame(player2, player1, 70);

            System.Console.WriteLine(player1.GetStats());
            System.Console.WriteLine(player2.GetStats());
        }
    }
}
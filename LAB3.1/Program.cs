namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            IAccountService accountService = new AccountService();
            GameAccount player1 = accountService.CreateAccount("premium", "Max");
            GameAccount player2 = accountService.CreateAccount("premium", "John");
            GameAccount player3 = accountService.CreateAccount("regular", "Alan");
            accountService.ReadAccounts();

            IGameService gameService = new GameService();
            gameService.PlayGame("regular",player1, player2, 10);
            gameService.PlayGame("training",player2, player1, 10);
            gameService.PlayGame("training",player3, player2, 10);
            gameService.PlayGame("regular",player1, player2, 10);
            gameService.PlayGame("training",player2, player1, 10);
            gameService.PlayGame("regular",player3, player2, 10);
            
            var allGames = gameService.GetAllGames();
            System.Console.WriteLine("All games");
            foreach(GameDomain game in allGames)
            {
                System.Console.WriteLine($"Game id: {game.gameId}| player {game.winnerName} ({game.winnerRating} rating) vs player {game.loserName} ({game.loserRating} rating)| Game bet:{game.gameBet}| game mode: {game.gameMode}");
            }
            System.Console.WriteLine();


            var JohnGames = gameService.GetGamesByName("John");
            System.Console.WriteLine("John's games");
            foreach(GameDomain game in JohnGames)
            {
                System.Console.WriteLine($"Game id: {game.gameId}| player {game.winnerName} ({game.winnerRating} rating) vs player {game.loserName} ({game.loserRating} rating)| Game bet:{game.gameBet}| game mode: {game.gameMode}");
            } 
            System.Console.WriteLine();

            var MaxGames = gameService.GetGamesByName("Max");
            System.Console.WriteLine("Max's games");
            foreach(GameDomain game in MaxGames)
            {
                System.Console.WriteLine($"Game id: {game.gameId}| player {game.winnerName} ({game.winnerRating} rating) vs player {game.loserName} ({game.loserRating} rating)| Game bet:{game.gameBet}| game mode: {game.gameMode}");
            } 
            System.Console.WriteLine();
            var AlanGames = gameService.GetGamesByName("Max");
            System.Console.WriteLine("Alan's games");
            foreach(GameDomain game in AlanGames)
            {
                System.Console.WriteLine($"Game id: {game.gameId}| player {game.winnerName} ({game.winnerRating} rating) vs player {game.loserName} ({game.loserRating} rating)| Game bet:{game.gameBet}| game mode: {game.gameMode}");
            } 
        }
    }
}
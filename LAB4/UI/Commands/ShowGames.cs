namespace MyGame
{
    public class ShowGames : ICommand
    {
        private DbContext context;
        public ShowGames(DbContext db)
        {
            context = db;
        }
        public string ShowInfo()
        {
            return "Show all games";
        }
        public void DoSmth()
        {
            var games = new GameService(context).GetAllGames();
            foreach(GameDomain game in games)
            {
                System.Console.WriteLine($"Game ID: {game.gameId} Game winner: {game.winnerName} Game loser: {game.loserName} Game bet: {game.gameBet}");
            }
        }
    }
}
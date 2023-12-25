namespace MyGame
{
   public class GameService : IGameService
   {
    public IGameRepository repository;
    public GameService(DbContext context)
    {
        repository = new GameRepository(context);
    }
        public void PlayGame(string gamemode, GameAccount winner, GameAccount loser, int bet)
        {
            new GameFactory().PlayGame(gamemode, winner, loser, bet);
            repository.PlayGame(gamemode, winner, loser, bet);
        }

        public IEnumerable<GameDomain> GetAllGames()
        {
            return repository.GetAllGames();
        }
        public IEnumerable<GameDomain> GetGamesByName(string name)
        {
            System.Console.WriteLine($"Games of The {name}");
            foreach(GameDomain game in repository.GetGamesByName(name))
            {
                System.Console.WriteLine($"Game ID: {game.gameId} Game winner: {game.winnerName} Game loser: {game.loserName}: Game bet: {game.gameBet}");
            }
            return repository.GetGamesByName(name);
        }
    }
}
namespace MyGame
{
   public class GameService : IGameService
   {
        public IGameRepository repository = new GameRepository();
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
            return repository.GetGamesByName(name);
        }
    }
}
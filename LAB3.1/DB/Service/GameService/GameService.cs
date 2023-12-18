namespace MyGame
{
   public class GameService : IGameService
   {
        public IGameRepository repository = new GameRepository();
        public void PlayGame(string gamemode, GameAccount winner, GameAccount loser, int bet)
        {
            repository.PlayGame(gamemode, winner, loser, bet);
        }

        public IEnumerable<GameMode> GetAllGames()
        {
            return repository.GetAllGames();
        }
        public IEnumerable<GameMode> GetGamesByName(string name)
        {
            return repository.GetGamesByName(name);
        }
    }
}
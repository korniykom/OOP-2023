namespace MyGame
{
    public class GameRepository : IGameRepository
    {
        private DbContext context;
        public GameRepository()
        {
            context = new ();
        }
        public IEnumerable<GameMode> GetAllGames()
        {
            return context.GetAllGames();
        }
        public void PlayGame (string gamemode, GameAccount winner, GameAccount loser, int bet)
        {
            context.CreateGame(new GameFactory().PlayGame(gamemode, winner, loser, bet));
        }
        public IEnumerable<GameMode> GetGamesByName(string name)
        {
            return context.GetGamesByName(name);
        }
    }
}
namespace MyGame
{
    public class GameRepository : IGameRepository
    {
        private DbContext context;
        public GameRepository(DbContext dbContext)
        {
            context = dbContext;
        }
        public IEnumerable<GameDomain> GetAllGames()
        {
            return context.GetAllGames();
        }
        public void PlayGame (string gamemode, GameAccount winner, GameAccount loser, int bet)
        {
            
            context.CreateGame(new GameDomain(gamemode,winner, loser, bet));
        }
        public IEnumerable<GameDomain> GetGamesByName(string name)
        {
            return context.GetGamesByName(name);

        }
    }
}
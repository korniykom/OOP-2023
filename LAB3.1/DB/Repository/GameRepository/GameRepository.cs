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
            return context.GameDB;
        }
        public GameMode Create(string gameMode)
        {
            GameMode game = new GameFactory().CreateGame(gameMode);
            context.GameDB.Add(game);
            return game;
        }
    }
}
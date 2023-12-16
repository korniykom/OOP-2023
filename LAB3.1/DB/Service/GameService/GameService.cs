namespace MyGame
{
    public class GameService : IGameService
    {
        public IGameRepository repository = new GameRepository();
        public GameMode Create(string gameMode)
        {
            GameMode game = new GameFactory().CreateGame(gameMode);
            return game;
        }
    }
}
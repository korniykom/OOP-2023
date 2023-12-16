namespace MyGame
{
    public class GameService : IGameService
    {
        public IGameRepository repository = new GameRepository();
        public GameMode Create(string gameMode)
        {
            GameMode game = repository.Create(gameMode);
            return game;
        }
    }
}
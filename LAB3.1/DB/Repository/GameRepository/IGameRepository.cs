namespace MyGame
{
    public interface IGameRepository
    {
        IEnumerable<GameMode> GetAllGames();
        GameMode Create (string gameMode);
    }
}
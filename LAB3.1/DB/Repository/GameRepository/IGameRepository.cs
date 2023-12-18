namespace MyGame
{
    public interface IGameRepository
    {
        void PlayGame (string gamemode,GameAccount winner, GameAccount loser, int bet);
        IEnumerable<GameMode> GetAllGames();
        IEnumerable<GameMode> GetGamesByName(string name);
    }
}
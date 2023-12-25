namespace MyGame
{
    public interface IGameRepository
    {
        void PlayGame (string gamemode,GameAccount winner, GameAccount loser, int bet);
        IEnumerable<GameDomain> GetAllGames();
        IEnumerable<GameDomain> GetGamesByName(string name);
    }
}
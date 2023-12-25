namespace MyGame
{
    public interface IGameService 
    {
        public void PlayGame(string gamemode,GameAccount winner, GameAccount loser, int bet);
        public IEnumerable<GameDomain> GetAllGames();
        public IEnumerable<GameDomain> GetGamesByName(string name);
    }
}
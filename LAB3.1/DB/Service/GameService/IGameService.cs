namespace MyGame
{
    public interface IGameService 
    {
        public void PlayGame(string gamemode,GameAccount winner, GameAccount loser, int bet);
        public IEnumerable<GameMode> GetAllGames();
        public IEnumerable<GameMode> GetGamesByName(string name);
    }
}
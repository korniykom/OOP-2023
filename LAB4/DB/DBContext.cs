namespace MyGame{
    public class DbContext
    {
        public List<GameAccount> PlayerDB {get; set;}
        public List<GameDomain> GameDB {get; set;}
        public DbContext()
        {
            PlayerDB = new ();
            GameDB = new ();
        }
        public void CreateAccount(GameAccount player)
        {
            PlayerDB.Add(player);
        }
        public GameAccount GetById(int id)
        {
            var player = PlayerDB.FirstOrDefault(player => player.id == id); 
            if(player != null) 
            {
                return player;
            } else {
                throw new ArgumentNullException("Account with given id does not exist");
            }
        }
        public void CreateGame(GameDomain game)
        {
            GameDB.Add(game);
        }
        public IEnumerable<GameDomain> GetAllGames()
        {
            return GameDB;
        }
        public IEnumerable<GameDomain> GetGamesByName(string name)
        {
            var games = new List<GameDomain>();
            foreach(GameDomain game in GameDB)
            {
                if(game.winnerName == name || game.loserName == name)
                {
                    games.Add(game);
                }
            }
            return games;
        }
    }
}
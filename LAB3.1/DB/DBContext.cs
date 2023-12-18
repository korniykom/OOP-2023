namespace MyGame{
    public class DbContext
    {
        public List<GameAccount> PlayerDB {get; set;}
        public List<GameMode> GameDB {get; set;}
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
        public void CreateGame(GameMode game)
        {
            GameDB.Add(game);
        }
        public IEnumerable<GameMode> GetAllGames()
        {
            return GameDB;
        }
        public IEnumerable<GameMode> GetGamesByName(string name)
        {
            var games = new List<GameMode>();
            foreach(GameMode game in GameDB)
            {
                if(game.winner.UserName == name || game.loser.UserName == name)
                {
                    games.Add(game);
                }
            }
            return games;
        }
    }
}
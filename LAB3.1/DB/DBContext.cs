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
    }
}
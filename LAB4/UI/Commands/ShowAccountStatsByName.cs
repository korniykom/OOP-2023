namespace MyGame
{
    public class ShowAccountStatsByName : ICommand
    {
        private DbContext context;
        public ShowAccountStatsByName(DbContext db)
        {
            context = db;
        }
        public string ShowInfo()
        {
            return "Show player statistic by player Name";
        }
        public void DoSmth()
        {
            System.Console.WriteLine("Enter player's name");
            string userName = Console.ReadLine();
            IGameService service = new GameService(context);
            System.Console.WriteLine("test");
            foreach(GameDomain game in service.GetGamesByName(userName))
            {
             System.Console.WriteLine($"Winner: {game.winnerName} Loser: {game.loserName}");   
            }
            
        }
    }
}
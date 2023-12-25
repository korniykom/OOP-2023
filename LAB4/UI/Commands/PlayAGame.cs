namespace MyGame
{
    public class PlayAGame : ICommand
    {
        private DbContext context;

        public PlayAGame(DbContext db)
        {
        context = db;
        }
        public string ShowInfo()
        {
            return "Play another game";
        }
        public void DoSmth()
        {
            System.Console.WriteLine("Enter winner's name");
            string winner = Console.ReadLine();
            
            System.Console.WriteLine("Enter loser's name");
            string loser = Console.ReadLine();
            
            System.Console.WriteLine("Enter game mode");
            string gameMode = Console.ReadLine();

            System.Console.WriteLine("Enter game's bet");
            string bet = Console.ReadLine();
            
            
            var gameService = new GameService(context);
            var accountService = new AccountService(context);
            gameService.PlayGame(gameMode, accountService.GetAccountByName(winner), accountService.GetAccountByName(loser), int.Parse(bet));

        }
    }
}
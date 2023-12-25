namespace MyGame
{
    public class ShowAccountName : ICommand
    {
        private DbContext context;
        public ShowAccountName(DbContext db)
        {
            context = db;
        }
        public string ShowInfo()
        {
            return "Show player statistic by player Name";
        }
        public void DoSmth()
        {

        }
    }
}
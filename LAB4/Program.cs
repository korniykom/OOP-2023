namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            DbContext db = new DbContext ();
            int i;

            List<ICommand> commandList = new List<ICommand>
                {
                    new ShowAccounts(db),
                    new CreateAccount(db),
                    new ShowAccountStatsByName(db),
                    new PlayAGame(db),
                    new ShowGames(db),
                };

            void DispalyMenu()
            {
                 
                i = 0;
                foreach (var command in commandList)
                {
                    System.Console.WriteLine($"{i++}. {command.ShowInfo()}");
                } 
                i = 0;
            }

            bool isRunning = true;

            while(isRunning)
            {
                DispalyMenu();
                string userInput = Console.ReadLine();
                if(userInput == "exit")
                {
                    isRunning = false;
                } 
                else
                {
                    commandList[int.Parse(userInput)].DoSmth();
                }              
            }


       

            
            
        }
    }
}
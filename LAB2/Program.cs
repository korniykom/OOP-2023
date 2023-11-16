namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            GameAccount[] players = new GameAccount[2];
            players[0] =  new AccountFactory().MakeAccount("premium", "Max");
            players[1] =  new AccountFactory().MakeAccount("regular", "John");

            BaseGameMode[] gameModes = new BaseGameMode[2];
            gameModes[0] = new GameFactory().CreateGame("training");
            gameModes[1] = new GameFactory().CreateGame("regular");
            
            gameModes[0].PlayAnGame(players[0], players[1], 100);
            gameModes[0].PlayAnGame(players[1], players[0], 200);
            gameModes[0].PlayAnGame(players[1], players[0], 50);
            gameModes[0].PlayAnGame(players[0], players[1], 70);
            
            gameModes[1].PlayAnGame(players[0], players[1], 100);
            gameModes[1].PlayAnGame(players[1], players[0], 200);
            gameModes[1].PlayAnGame(players[0], players[1], 50);
            gameModes[1].PlayAnGame(players[1], players[0], 70);

            System.Console.WriteLine(players[0].GetStats());
            System.Console.WriteLine(players[1].GetStats());

        }
    }
}
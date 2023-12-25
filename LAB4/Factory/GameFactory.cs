namespace MyGame
{
    public class GameFactory
    {
        public GameMode PlayGame(string gameMode, GameAccount winner, GameAccount loser, int bet)
        {
            if(gameMode != "training" && gameMode != "regular")
            {
                throw new ArgumentException("Enter valid Game Mode");
            }
            if(gameMode == "training")
            {
                return new TrainingGameMode(winner, loser, bet);
            }
            else
            {
                return new RegularGameMode(winner, loser, bet);
            }
        }
    }
}
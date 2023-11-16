namespace MyGame
{
    public class GameFactory
    {
        public BaseGameMode CreateGame(string gameMode)
        {
            if(gameMode != "training" && gameMode != "regular")
            {
                throw new ArgumentException("Enter valid Game Mode");
            }
            if(gameMode == "training")
            {
                return new TrainingGameMode();
            }
            else
            {
                return new RegularGameMode();
            }
        }
    }
}
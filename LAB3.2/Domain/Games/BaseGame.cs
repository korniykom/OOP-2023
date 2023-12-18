namespace MyGame
{
    public abstract class BaseGame
    {
        public abstract BaseGame PlayAGame(BaseAccount winner, BaseAccount loser, int bet);
        public int gameId;
        public static int gameIdSeed = 1;
        public string winnerName;
        public int winnerRating;
        public string loserName;
        public int loserRating;
        public int gameBet;
        public BaseGame(BaseAccount winner, BaseAccount loser, int bet)
        {
            winnerName = winner.userName;
            winnerRating = winner.CurrentRating;
            loserName = loser.userName;
            loserRating = loser.CurrentRating;
            gameId = ++gameIdSeed;
            gameBet = bet;
        }
    }
}
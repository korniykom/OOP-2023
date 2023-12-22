namespace MyGame
{
    public class GameDomain
    {
        public GameAccount winner;
        public GameAccount loser;

        public string gameMode;
        public string winnerName;
        public string loserName;
        public int winnerRating;
        public int loserRating;
        public int gameBet;
        public int gameId;
        public static int gameIdSeed = 0;
        public GameDomain(string gameMode,GameAccount winner, GameAccount loser, int bet)
        {
            this.winner = winner;
            this.loser = loser;
            this.gameBet = bet;
            this.gameId = ++gameIdSeed;
            this.winnerRating = winner.CurrentRating;
            this.loserRating = loser.CurrentRating;
            this.winnerName = winner.UserName;
            this.loserName = loser.UserName;
            this.gameMode = gameMode;
        }
    }
}
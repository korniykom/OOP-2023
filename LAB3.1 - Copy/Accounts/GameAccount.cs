using Lab2.Games;
using Laba3.Accounts.States;

namespace Lab2.Accounts
  {
    public class GameAccount
      {
        public string UserName { get; set; }

        public PlayerType Type { get; set; }

        private static int playerId = 1;

        public int playerID;

        private int rating;

        public int Rating
          {
            get => rating;
            set => rating = value < 1 ? 1 : value;
          }

        public GameAccount(string UserName, int rating)
          {
            this.UserName = UserName;
            this.rating = rating;
            playerID = playerId++;  
          }

        public void ChangeRating(Game game, GameAccount loser)
          {
            WinGame(game);  
            loser.LoseGame(game);  
          }
        public virtual void WinGame(Game game)
          {
             Rating = Rating + game.GetRating(this); 
          }
        public virtual void LoseGame(Game game)
          {
             Rating = Rating - game.GetRating(this);  
          }
      }
  }
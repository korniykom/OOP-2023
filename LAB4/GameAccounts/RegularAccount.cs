using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame 
{   
    public class RegularAccount : GameAccount
    {
        public RegularAccount(string name) : base(name)
        {
                CurrentRating = 1;
        }
        public override int CalculatePoints(int bet, string outcome)
        {
            if( outcome != "Win" && outcome != "Lose")
            {
                 throw new ArgumentException("Parameter should be \"Win\" or \"Lose\"");
            }   
            return bet;
        }
    }
}   
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cardgame
{
    
    public class Player
    {
        public int playerrank = 0;
        public List<Card> Hand = new List<Card>();
        public void showhand( List<Card>Player)
        {
           for(int i = 0; i < Player.Count; i++)
            {
                Console.WriteLine(Player[i].Rank + " " + Player[i].Suit);
            }
        }
        

    }
   
}

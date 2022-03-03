using System;

namespace Cardgame
{
    public class Card
    {
        int rank;
        string suit;
        

        public Card(int rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int Rank
        {
            get { return rank; }  //c.Rank 
            set { rank = value; } //c.Rank = calculation;
        }

        public string Suit
        {
            get { return suit; }  //getSuit
            set { suit = value; } //setSuit {suit = xxx;}
        }

    }
}

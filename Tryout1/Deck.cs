using System;
using System.Collections.Generic;
using System.Text;

namespace Cardgame
{
    public class Deck
    {
        List<Card> cards = new List<Card>();

        string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
        // List<string> suit = {"Clubs", "Diamonds", "Hearts", "Spades"};

       
        public Deck()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    cards.Add(new Card(i, suit[j]));
                }
            }
        }

        public Card TopCard()
        {
            if (cards.Count > 0)
            {
                Card topCard = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                return topCard;
            }
            return null;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int randomIdx = rand.Next(i + 1);
                Card tempCard = cards[i];
                cards[i] = cards[randomIdx];
                cards[randomIdx] = tempCard;
            }
        }

        public void Print()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i].Rank + " " + cards[i].Suit);
            }
        }

    }
}

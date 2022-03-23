using System;
using System.Collections.Generic;
using System.Text;

namespace Cardgame
{
    class Program
    {
        public static void Main(string[] args)
        {

            
            Deck deck = new Deck();
            Deck deck2 = new Deck();
            System system = new System();
            Player player = new Player();
           
            List<Card> Player1 = new List<Card>();
            List<Card> Player2 = new List<Card>();
            List<Card> Player3 = new List<Card>();
            
            deck.Shuffle();
            deck2.Shuffle();
            system.dealer(deck, 4, Player1);
            system.dealer(deck, 4, Player2);
            system.compare(system.totalRank(Player1), system.totalRank(Player2));
            Console.WriteLine("\nPlayer 1: ");
            player.showhand(Player1);
            Console.WriteLine("Player 2: ");
            player.showhand(Player2);
            //deal 5 cards and add them to a new card List.
            //Implement a method to take the card list as parameter, and compute and print cards in each suit.
            Console.WriteLine("\nPlayer 3(Before removing Jack,Queen or King): ");
            system.dealer(deck2, 5, Player3);
            player.showhand(Player3);
            system.replaceCards(deck,Player3);
            Console.WriteLine("\nPlayer3(After Removing Jack, Queen or King): ");
            player.showhand(Player3);
        }
    }
}

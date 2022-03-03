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
            System system = new System();
            Player player = new Player();
            List<Card> Player1 = new List<Card>();
            List<Card> Player2 = new List<Card>();
            deck.Shuffle();
            system.dealer(deck,4, Player1);
            system.dealer(deck,4, Player2);
            player.showhand(Player1);
            Console.WriteLine();
            //player.showhand(Player2);
            //system.totalRank(Player1);
            //system.compare(system.totalRank(Player1), system.totalRank(Player2));
            system.discard(deck,Player1);
            player.showhand(Player1);





















        }
    }
}

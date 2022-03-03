using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cardgame
{
    public class System
    {


        /*public void dealcards(Deck d, params List<Card>[]Playerhand)
        {
            Console.Write("How many cards to deal");
            var cardcount = Console.Read();

            for (int j = 0; j < cardcount; j++)
            {
                for (int i = 0; i < Playerhand.Length; i++)
                {
                    Playerhand[i].Add(d.TopCard());
                }
            }
        }
        */

        public void dealer(Deck d, int CardCount,List<Card>Playerhand)
        {
            for(int i = 0; i < CardCount; i++)
            {
                Playerhand.Add(d.TopCard());
            }
        }
        

        
        
       public int totalRank(List<Card>Playerhand)
        {
            int total = 0;
            for(int i = 0; i < 4; i++)
            {
                total += Playerhand[i].Rank;
                
            }
            return total;
        }

        public void compare(int num, int num2)
        {
          if(num > num2)
            {
                Console.WriteLine("Player one won ");

            }
          else
            {
                Console.Write("Player two won ");
            }
        }

        public void discard(Deck d,List<Card>List)
        {
            for(int i = 0; i < List.Count; i++)
            {
                if(List[i].Rank > 10)
                {
                    List.RemoveAt(i);
                    List.Add(d.TopCard());
                }
            }
        }
    }


    
}

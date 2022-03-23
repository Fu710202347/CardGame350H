using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cardgame
{
    public class System
    {
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

        public void replaceCards(Deck d,List<Card>List)
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

    
        public bool checkHands(List<Card>List)
        {
            for(int i = 0; i < List.Count; i++)
            {
                for(int j = i++; j < List.Count; j++)
                {
                    if (List[i].Rank + List[j].Rank == 10)
                        return true;
                    
                }
            }
            return false;
        }
        public void swapcards(Deck d, List<Card>List, Player p)
        {
           
            int Card1, Card2;
            dealer(d,10,List);
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine("Card " + i + "------->" + List[i].Rank + " " + List[i].Suit);
            }
            while (checkHands(List) == true)
            {
                
                Console.WriteLine("Enter First Card");
                Card1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Card");
                Card2 = Int32.Parse(Console.ReadLine());
                while(Card1 < 0 || Card2 < 0 || List[Card1].Rank + List[Card2].Rank != 10 || Card1 > List.Count || Card2 > List.Count)
                {

                    Console.WriteLine("Enter First Card");
                    Card1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Card");
                    Card2 = Int32.Parse(Console.ReadLine());


                }
                List.RemoveAt(Card1);
                List.Insert(Card1, d.TopCard());
                List.RemoveAt(Card2);
                List.Insert(Card1, d.TopCard());
                for (int i = 0; i < List.Count; i++)
                {
                    Console.WriteLine("Card " + i + "------->" + List[i].Rank + " " + List[i].Suit);
                }
            }          
        }
    }


    
}

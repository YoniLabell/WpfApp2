using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Game
    {

        public CardStock packet = new CardStock();
        public Player player1 = new Player("yoni");
        public Player player2 = new Player("moshe");
        public override string ToString()
        {

            return ($" {player1.ToString()} \n {player2.ToString()}");
        }
        public void startGame()
        {
            packet.mix();
            packet.distribute(player1, player2);
        }
        public string winer()
        {
            if (player1.lose())
            {
                return player2.name;
            }
            if (player2.lose())
            {
                return player1.name;
            }
            return null;
        }
        public bool gameover()
        {
            if (winer() == null)
            {
                return false;
            }
            return true;
        }
        public void step()
        {
            Queue<Card> temp = new Queue<Card>();

            Card a = player1.pop();
            Card b = player2.pop();
            temp.Enqueue(a);
            temp.Enqueue(b);
            while (a.CompareTo(b) == 0)
            {
                if (player1.plerCards.Count < 5)
                {
                    foreach (Card item in temp)
                    {
                        player2.addCard(item);
                    }
                    foreach (Card item in player1.plerCards)
                    {

                        player2.addCard(item);
                    }
                    player1.plerCards.Clear();
                    return;
                }
                if (player2.plerCards.Count < 5)
                {
                    foreach (Card item in temp)
                    {
                        player1.addCard(item);
                    }
                    foreach (Card item in player2.plerCards)
                    {

                        player1.addCard(item);
                    }
                    player2.plerCards.Clear();
                    return;
                }

                for (int i = 0; (i < 4); i++)
                {

                    a = player1.pop();
                    b = player2.pop();
                    temp.Enqueue(a);
                    temp.Enqueue(b);

                }
               
                


            }

            if (a.CompareTo(b) > 0)
            {

                foreach (Card item in temp)
                {
                    player1.addCard(item);
                }
            }
            if (a.CompareTo(b) < 0)
            {

                foreach (Card item in temp)
                {
                    player2.addCard(item);
                }
            }
        }

    }
}

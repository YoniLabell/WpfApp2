using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Player
    {
        private string A_name;
        public string name
        {
            get { return A_name; }
        }
        public Player(string name)
        {
            A_name = name;
        }
        public Queue<Card> plerCards = new Queue<Card>();
        public void addCard(params Card[] cards)
        {
            foreach (Card item in cards)
            {
                plerCards.Enqueue(item);
            }
        }
        public override string ToString()
        {
            string a;
            a = (name + " with: " + plerCards.Count + " cards ");
            foreach (Card item in plerCards)
            {
                a += item.ToString();
            }
            return a;
        }
        public bool lose()
        {
            if (plerCards.Count == 0)
            {
                return true;
            }
            return false;
        }
        public Card pop()
        {
            return plerCards.Dequeue();
        }
    }
}

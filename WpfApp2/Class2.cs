using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class CardStock
    {
        List<Card> Cards = new List<Card>();
        private static Random r = new Random();
        public CardStock() //constr
        {
            for (int i = 2; i < 15; i++)
            {
                Cards.Add(new Card(E_Color.black, i, shape.Clubs));
                Cards.Add(new Card(E_Color.red, i, shape.Diamond));
                Cards.Add(new Card(E_Color.black, i, shape.Hearts));
                Cards.Add(new Card(E_Color.red, i, shape.Spades));
            }

        }
        public void mix()
        {
            Card temp;
            int a, b;
            for (int i = 0; i < 1000; i++)
            {
                a = r.Next(0, 52);
                b = r.Next(0, 52);
                temp = new Card(Cards[a].color, Cards[a].num, Cards[a].shape);
                Cards[a] = Cards[b];
                Cards[b] = temp;
            }
        }
        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < 52; i++)
            {
                temp += (" " + Cards[i].ToString());
            }
            return temp;
        }
        public void distribute(params Player[] players)
        {
            int j = 0;
            foreach (Player p in players)
            {
                for (int i = 0; i < 26; i++)
                {
                    p.addCard(Cards[j]);
                    j++;
                }
            }
        }
        public Card this[string i]
        {
            get
            {
                foreach (Card item in Cards)
                {
                    if (item.CardName == i)
                    {
                        return item;
                    }

                }
                return null;
            }

        }
        public void sort()
        {
            Card temp;
            for (int i = Cards.Count; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (Cards[j].CompareTo(Cards[j + 1]) > 0)
                    {
                        temp = new Card(Cards[j].color, Cards[j].num, Cards[j].shape);
                        Cards[j] = new Card(Cards[j + 1].color, Cards[j + 1].num, Cards[j + 1].shape);
                        Cards[j + 1] = new Card(temp.color, temp.num, temp.shape);
                    }
                }
            }
        }
        public CardStock addCard(Card card)
        {
            Cards.Add(card);
            return this;
        }
        public CardStock removeCard(Card card)
        {
            Cards.Remove(card);
            return this;

        }

    }
}

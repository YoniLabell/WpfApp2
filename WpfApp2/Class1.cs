using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public enum E_Color { red, black }
    public enum shape { Spades, Hearts, Diamond, Clubs }
    public class Card : IComparable<Card>
    {
        private E_Color A_color;
        public E_Color color
        {
            get { return A_color; }

            set { A_color = value; }
        }
        private shape A_shape;
        public shape shape
        {
            get { return A_shape; }

            set { A_shape = value; }
        }
        private int A_num;
        public int num
        {
            get { return A_num; }
            set
            {
                if (value <= 14 && value >= 2)
                {
                    A_num = value;
                }
            }
        }
        public string CardName
        {
            get
            {


                if (A_num == 11) { return "Jack"; }
                if (A_num == 12) { return "Queen"; }
                if (A_num == 13) { return "King"; }
                if (A_num == 14) { return "Ace"; }
                return A_num.ToString();


            }
        }
        public Card(E_Color _color, int num, shape A_shape)
        {
            this.A_color = _color;
            this.num = num;
            this.shape = A_shape;
        }
        public override string ToString()
        {

            return ($"{color} {" "}{CardName}{" "}{A_shape}");
        }
        public int CompareTo(Card card)
        {
            return A_num.CompareTo(card.A_num);
        }
    }
}

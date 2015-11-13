using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGame
{
    public class Set
    {
        private List<Card> cards;

        public Set(Card c1, Card c2, Card c3)
        {
            cards = new List<Card>();
            cards.Add(c1);
            cards.Add(c2);
            cards.Add(c3);
        }

        public override string ToString()
        {
            string setString = "";
            foreach(Card c in cards)
            {
                setString += c.ToString() + "\n";
            }
            return setString;
        }
    }
}

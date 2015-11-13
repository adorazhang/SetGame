using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGame
{
    public class Board
    {
        private List<Card> cards;

        public Board()
        {
            this.cards = new List<Card>();
        }

        /// <summary>
        /// Returns true if three cards make up a set
        /// </summary>
        /// <param name="card 1"></param>
        /// <param name="card 2"></param>
        /// <param name="card 3"></param>
        /// <returns></returns>
        public bool IsASet(Card c1, Card c2, Card c3)
        {
            bool isASet = false;
            if ((c1.hasSameColor(c2, c3) || c1.hasDifferentColors(c2, c3)) &&
                (c1.hasSameShading(c2, c3) || c1.hasDifferentShadings(c2, c3)) &&
                (c1.hasSameShape(c2, c3) || c1.hasDifferentShapes(c2, c3)) && 
                (c1.hasSameNumber(c2, c3) || c1.hasDifferentNumbers(c2, c3)))
            {
                isASet = true;
            }
            return isASet;
        }

        /// <summary>
        /// Returns true if current board has a set
        /// It has a time complexity of O(n^3), 
        /// which is bad but can't really think of a better approach
        /// </summary>
        /// <returns></returns>
        internal Set HasASet()
        {
            if(cards.Count < 3)
            {
                return null;
            }
            for(int i = 0; i < cards.Count - 2; i++)
            {
                for(int j = i + 1; j < cards.Count - 1; j++)
                {
                    for(int k = j + 1; k < cards.Count; k++)
                    {
                        if(IsASet(cards[i], cards[j], cards[k]))
                        {
                            Set set = new Set(cards[i], cards[j], cards[k]);
                            cards.RemoveAt(k);
                            cards.RemoveAt(j);
                            cards.RemoveAt(i);
                            return set;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Adds a card to the board
        /// </summary>
        /// <param name="card"></param>
        internal void AddCard(Card card)
        {
            cards.Add(card);
        }
    }
}

using System;
using System.Threading;

namespace SetGame
{
    public class Card
    {
        private readonly int cardNum;
        private readonly Enums.Color color;
        private readonly Enums.Shading shading;
        private readonly Enums.Shape shape;
        private readonly Enums.Number number;

        public Card(int cardNum)
        {
            this.cardNum = cardNum;
            Thread.Sleep(20);
            Random random = new Random((int)DateTime.Now.Ticks);
            Array allColors = Enum.GetValues(typeof(Enums.Color));
            Array allShadings = Enum.GetValues(typeof(Enums.Shading));
            Array allShapes = Enum.GetValues(typeof(Enums.Shape));
            Array allNumbers = Enum.GetValues(typeof(Enums.Number));
            this.color = (Enums.Color)allColors.GetValue(random.Next(allColors.Length));
            this.shading = (Enums.Shading)allShadings.GetValue(random.Next(allShadings.Length));
            this.shape = (Enums.Shape)allShapes.GetValue(random.Next(allShapes.Length));
            this.number = (Enums.Number)allNumbers.GetValue(random.Next(allNumbers.Length));
        }

        internal bool hasDifferentNumbers(Card c2, Card c3)
        {
            return c2.number != this.number && c3.number != this.number && c2.number != c3.number;
        }

        internal bool hasDifferentShapes(Card c2, Card c3)
        {
            return c2.shape != this.shape && c3.shape != this.shape && c2.shape != c3.shape;
        }

        internal bool hasDifferentShadings(Card c2, Card c3)
        {
            return c2.shading != this.shading && c3.shading != this.shading && c2.shading != c3.shading;
        }

        internal bool hasDifferentColors(Card c2, Card c3)
        {
            return c2.color != this.color && c3.color != this.color && c2.color != c3.color;
        }

        internal bool hasSameNumber(Card c2, Card c3)
        {
            return c2.number == this.number && c3.number == this.number;
        }

        internal bool hasSameShape(Card c2, Card c3)
        {
            return c2.shape == this.shape && c3.shape == this.shape;
        }

        internal bool hasSameShading(Card c2, Card c3)
        {
            return c2.shading == this.shading && c3.shading == this.shading;
        }

        internal bool hasSameColor(Card c2, Card c3)
        {
            return c2.color == this.color && c3.color == this.color;
        }

        public override string ToString()
        {
            string cardString = "Card # " + cardNum + ": ";
            cardString += color + ", " + shading + ", " + shape + ", " + number;
            return cardString;
        }
    }
}

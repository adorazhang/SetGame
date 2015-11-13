using System.Collections.Generic;

namespace SetGame
{
    /// <summary>
    /// A static class for all card properties as enums
    /// </summary>
    public static class Enums
    {
        public enum Color
        {
            Red = 1,
            Green = 2,
            Purple =3
        };

        public enum Shape
        {
            Diamond = 1,
            Squiggle = 2,
            Oval = 3
        };

        public enum Shading
        {
            Solid = 1,
            Empty = 2,
            Striped = 3
        };

        public enum Number
        {
            One = 1,
            Two = 2,
            Three = 3
        };
    }
}

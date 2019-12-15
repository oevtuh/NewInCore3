using System;
using System.Collections.Generic;
using System.Text;

namespace NewInCore3
{
    public enum Color
    {
        Unknown,
        Red,
        Blue,
        Green,
        Purple,
        Orange,
        Brown,
        Yellow
    }

    public static class TuplePatternSample
    {
        public static Color GetColor(Color c1, Color c2)
        {
            var result = (c1, c2) switch
            {
                (Color.Red, Color.Blue) => Color.Purple,
                (Color.Blue, Color.Red) => Color.Purple,

                (Color.Yellow, Color.Red) => Color.Orange,
                (Color.Red, Color.Yellow) => Color.Orange,

                (Color.Red, Color.Green) => Color.Brown,
                (Color.Green, Color.Red) => Color.Brown,

                (_, _) when c1 == c2 => c1,

                _ => Color.Unknown
            };

            return result;
        }
    }
}

namespace ColorBallsWithProperties
{
    public class Color
    {
        public byte Red{get;}
        public byte Green{get;}
        public byte Blue{get;}
        public byte Alpha{get;}
        public byte Grey{get => (byte)((Red + Green + Blue) / 3);}

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
    }
}
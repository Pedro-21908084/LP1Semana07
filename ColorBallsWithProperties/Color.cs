namespace ColorBalls
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
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.red = 255;
        }
    }
}
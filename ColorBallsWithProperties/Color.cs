namespace ColorBallsWithProperties
{
    public class Color
    {
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }
        public byte Alpha { get; }

        public string Name
        {
            get
            {
                return this switch
                {
                    { Red: 255, Green: 0, Blue: 0 } => "100% red!",
                    { Red: 0, Green: 255, Blue: 0 } => "100% green!",
                    { Red: 0, Green: 0, Blue: 255 } => "100% blue!",
                    _=> "Mixed"
                };
            }
        }
        public byte Grey { get => (byte)((Red + Green + Blue) / 3); }

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
namespace ColorBallsWithProperties
{
    public class Ball
    {
        public Color Color{get;}
        private float radius;
        public int ThrowTimes{get;private set;}

        public Ball(Color color, float radius)
        {
            Color = color;
            this.radius = radius;
        }
        public Ball(float radius)
        {
            Color = new Color(255, 0, 0);
            this.radius = radius;
        }
        public Ball()
        {
            Color = new Color(255, 0, 0);
            radius = 1.0f;
        }

        public void Pop() => radius = 0;

        public void Throw()
        {
            if (radius > 0)
                ThrowTimes++;
        }
    }
}
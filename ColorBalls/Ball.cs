namespace ColorBalls
{
    public class Ball
    {
        private readonly Color color;
        private float radius;
        private int throwTimes;

        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
        }
        public Ball(float radius)
        {
            color = new Color(255, 0, 0);
            this.radius = radius;
        }
        public Ball()
        {
            color = new Color(255, 0, 0);
            radius = 1.0f;
        }

        public void Pop() => radius = 0;

        public void Throw()
        {
            if (radius > 0)
                throwTimes++;
        }

        public int GetThrowTimes() => throwTimes;
    }
}
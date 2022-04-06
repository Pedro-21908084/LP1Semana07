using System;

namespace ColorBallsWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Color green = new Color(0, 255, 0);
            Ball ball1 = new Ball(green, 2.0f);
            Ball ball2 = new Ball();
            Ball ball3 = new Ball(5.0f);
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            //throws
            ball1.Throw();
            ball1.Throw();
            ball1.Pop();
            ball1.Throw();

            for(int i =0; i<10;i++)
                ball2.Throw();

            for(int i = 0; i<randomNumber;i++)
                ball3.Throw();

            ball3.Pop();

            //print

            Console.WriteLine($"Ball 1 was throw {ball1.ThrowTimes} times");
            Console.WriteLine($"Ball 2 was throw {ball2.ThrowTimes} times");
            Console.WriteLine($"Ball 3 was throw {ball3.ThrowTimes} times");
            Console.WriteLine("Color of ball 2 is: " + ball3.Color.Name);
        }
    }
}

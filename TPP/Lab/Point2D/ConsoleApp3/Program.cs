using System;

namespace TPP.Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D a = new Point2D(1, 2, Color.Black),
                b = new Point2D(1, 1, Color.Transparent);
            Point2D c = new Point2D {C = Color.Red, Y = 0, X = 1};
            Console.WriteLine($"Distance from {a} to {b} is {a.Distance(b)}");
        }
    }
}
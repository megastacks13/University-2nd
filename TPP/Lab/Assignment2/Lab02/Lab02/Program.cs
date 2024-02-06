using System;


namespace TPP.Lab02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point2D[] t;
            t = GenerateTrajectory(5, -5, 2, .5, .5);
            ShowTrajectory(t);
            double d;
            Point2D s, e;
            DistanceStartEnd(t, out d, out s, out e);
            Console.WriteLine($"{d}, {s}, {e}\n");
            e.X = 666;
            ShowTrajectory(t);
            Console.WriteLine(123.Reverse());
            Console.WriteLine(12.IsPrime());
            Console.WriteLine(5.IsPrime());
            Console.WriteLine(17.IsPrime());

        }
        static void IncrementTwoDouble(ref double d, ref double d2, double d3, double d4)
        {
            d += d3;
            d2 += d4;
        }

        static Point2D[] GenerateTrajectory(int length = 10, double x = 0.0, double y = 0.0, double xIncrement = 1.0, double yIncrement = 1.0)
        {
            Point2D[] points = new Point2D[length];
            points[0] = new Point2D(x, y);
            for (int i = 1; i < length; i++)
            {
                IncrementTwoDouble(ref x, ref y, xIncrement, yIncrement);
                points[i] = new Point2D(x, y);
            }
            return points;
        }
        static void ShowTrajectory(Point2D[] points, bool showOnlyFirstQuadrant = false)
        {
            String trajectory = "";
            foreach(Point2D p in points) { 
                if (showOnlyFirstQuadrant && p.X < 0 && p.Y < 0)
                {
                    continue;
                }
                trajectory += p + "\n";
            }
            Console.WriteLine( trajectory );
        }

        static void DistanceStartEnd(Point2D[] points, out double distance, out Point2D start, out Point2D end) 
        { 
            start = points[0];
            distance = 0;
            end = start;
            for (int i = 1; i < points.Length; i++)
            {
                end = points[i];
                distance += points[i - 1].Distance(points[i]);
            }
        }


    }
}

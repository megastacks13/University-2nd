using System;
using System.Diagnostics;

namespace TPP.Lab02
{
    //In the class library define the enum Color with the values
    //Transparent, Black and Red.
    /// <summary>
    /// An enumeration that represents colors
    /// </summary>
    public enum Color { Transparent, Black, Red };
    /// <summary>
    /// A class that represents bidimensional points
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// The coordinates
        /// </summary>
        double x, y;
        /// <summary>
        /// The color
        /// </summary>
        Color c;
        // Default constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Point2D() { }
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Overloaded constructor
        public Point2D(double x, double y, Color color)
        {
            this.x = x;
            this.y = y;
            c = color;
        }

        // Destructor
        ~Point2D()
        {
            Console.WriteLine($"Point2D destructor {this.x}, {this.y}");
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Color C
        {
            get { return c; }
            set { c = value; }
        }
        public double Azimuth
        {
            get
            {
                return Math.Atan2(y, x);
            }
        }
        // Methods:
        // Euclidean distance between two points
        /// <summary>
        /// Computes the euclidean distance from the calller to the parameter
        /// </summary>
        /// <param name="p"> the "to" point</param>
        /// <returns>The distance as a double</returns>
        public double Distance(Point2D p)
        {
#if DEBUG
            Trace.WriteLine($"Trace  conditional compilation {this} to {p})");
#endif
            Trace.WriteLine($"Trace  unconditional compilation {this} to {p})");
            Debug.WriteLine($"Debug  message{this} to {p})");
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }
        // ToString, a poin2d with x = 1.0, y=2.0, c=Red is shown as (1,0;2,0):Red.
        public override string ToString()
        {
            return $"({x};{y}):{c}";
        }
    }
}
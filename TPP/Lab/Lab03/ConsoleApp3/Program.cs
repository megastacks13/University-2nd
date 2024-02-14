using System;
using Intervals;
namespace ConsoleApp3
{
    internal class Program
    {
        // code here the polymorphic method, returns IMedible, takes two Imedible as arguments

        static void Main(string[] args)
        {
            // check all the methods and constructors for each type (Interval, Bar), use try/catch/finally
            Console.WriteLine(new Program().HighestSize(new Interval(100, 200), new Bar(10, 20, 30)));

        }

        public IMedible HighestSize(IMedible a, IMedible b)
        {
            return a.Size() < b.Size() ? b : a;
        }
    }
}

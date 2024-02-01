using System;

namespace TPP.LinkedList
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            LinkedListClass l = new LinkedListClass(2);
            l.Add(1);
            Console.WriteLine(l.ToString());
            l.Remove(1);
            l.Remove(2);
            Console.WriteLine(l.ToString());
            int[] intArr = {1, 2, 3, 4, 5, 5, 4, 12, 1293};
            l.Add(intArr);
            Console.WriteLine(l.ToString());
            l.Remove(5);
            Console.WriteLine(l.ToString());
            Console.WriteLine($"{l.getElement(5)} is the element at position 5");
        }
    }
}

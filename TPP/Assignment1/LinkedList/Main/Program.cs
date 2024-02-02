using System;

namespace TPP.LinkedList
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            LinkedListClass l = new LinkedListClass(2);
            l.Add(1);
            Console.WriteLine(l.ToString() + "--->" + " 2 - 1");
            l.Remove(1);
            l.Remove(2);
            l.Remove(3);
            Console.WriteLine(l.ToString() + "--->" + " Empty");
            int[] intArr = {1, 2, 3, 4, 5, 5, 4, 12, 1293};
            l.Add(intArr);
            Console.WriteLine(l.ToString() + "--->" + " 1 - 2 - 3 - 4 - 5 - 5 - 4 - 12 - 1293");
            l.Remove(5);
            Console.WriteLine(l.ToString() + "--->" + " 1 - 2 - 3 - 4 - 5 - 4 - 12 - 1293");
            Console.WriteLine($"{l.getElement(5)} is the element at position 5");
        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace TPP.LinkedList
{
    public class SetClass : LinkedListClass
    {
        static void Main(string[] args)
        {

        }
        public SetClass(Object head) : base(head) { }

        public override void Add(Object nodeValue)
        {
            if (Search(nodeValue)) { return; }
            if (head == null)
            {
                head = new Node(nodeValue);
                tail = head;
                return;
            }
            Node nextTail = new Node(nodeValue);
            tail.AddLink(nextTail);
            tail = nextTail;
            numberOfElements++;
        }

        internal static SetClass Union(SetClass list1, SetClass list2)
        {
            Node actual = list1.head;
            SetClass retVal = new SetClass(actual.Value);
            for (int i = 0; i < list1.numberOfElements; i++)
            {
                retVal.Add(actual.Value);
                actual = actual.Next;
            }
            actual = list2.head;
            for (int i = 0; i < list2.numberOfElements; i++)
            {
                retVal.Add(actual.Value);
                actual = actual.Next;
            }
            return retVal;
        }
        internal static SetClass Intersection(SetClass list1, SetClass list2)
        {
            Node actual = list1.head;
            bool newHeadSet = false;
            SetClass retVal = new SetClass(actual.Value);

            for (int i = 0; i < list1.numberOfElements; i++)
            {
                if (list2.Search(actual.Value))
                { 
                    if (!newHeadSet)
                    {
                        retVal.head = new Node(actual.Value);
                        newHeadSet = true;
                    }
                    else { retVal.Add(actual.Value);}
                }
                actual = actual.Next;
            }
            actual = list2.head;
            for (int i = 0; i < list2.numberOfElements; i++)
            {
                if (list1.Search(actual.Value))
                {
                    retVal.Add(actual.Value); 
                }
                actual = actual.Next;
            }
            return retVal;
        }

        internal static SetClass Difference(SetClass list1, SetClass list2)
        {
            Node actual = list1.head;
            SetClass returnVal = new SetClass(list1.head.Value);
            for (int i = 0; i < list1.numberOfElements; i++)
            {
                if (!list2.Search(actual.Value))
                {
                    returnVal.Add(actual.Value);
                }
                actual = actual.Next;
            }
            actual = list2.head;
            for (int i = 0; i < list2.numberOfElements; i++)
            {
                if (!list1.Search(actual.Value))
                {
                    returnVal.Add(actual.Value);
                }
                actual = actual.Next;
            }

            return returnVal;

        }

        public static SetClass operator +(SetClass list, Object element) {
            list.Add(element);
            return list;
        }

        public static SetClass operator -(SetClass list, Object element)
        {
            list.Remove(element);
            return list;
        }
        public static SetClass operator -(SetClass list1, SetClass list2)
        {
            return SetClass.Difference(list1, list2);
        }

        public Object this[int index]
        {
            get => GetElement(index);
        }

        public static bool operator ^(SetClass list, Object element) {
            return list.Search(element);
        }

        public static SetClass operator |(SetClass list1, SetClass list2) 
        {
            return SetClass.Union(list1, list2);
        }

        public static SetClass operator &(SetClass list1, SetClass list2)
        {
            return SetClass.Intersection(list1, list2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP.LinkedList
{
    /// <summary>
    /// Class containing the LinkedList
    /// </summary>

    public class LinkedListClass
    {
        private Node head;
        private Node tail;
        private int numberOfElements;


        /// <summary>
        /// Constructor given an integer node value that will define the head of the Linked List
        /// </summary>
        /// <param name="headValue"> Ineteger expected to be the value of the head of the linked list</param>
        public LinkedListClass(int headValue) {
            this.head = new Node(headValue);
            this.tail = head;
            numberOfElements = 1;
        }

        /// <summary>
        /// Constructor that builds a linked list from an array of values
        /// </summary>
        /// <param name="nodesValues">Array contining the values to be inserted </param>
        /// <exception cref="ArgumentNullException"> Thrown when the received array is null</exception>
        public LinkedListClass(int[] nodesValues) 
        {
            if (nodesValues == null) throw new ArgumentNullException("Invalid null array for the new Linked List");
            head = new Node(nodesValues[0]);

            if (nodesValues.Length == 1) return;

            for (int i = 1; i < nodesValues.Length; i++) 
            {
                Add(nodesValues[i]);
            }
       
        }

        /// <summary>
        /// Given an integer value to add, it will be added to the end of the Linked List
        /// </summary>
        /// <param name="nodeValue"> value of the node we want to add</param>
        public void Add(int nodeValue)
        {
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

        /// <summary>
        /// Given an integer array to add, they will be added to the end of the Linked List
        /// </summary>
        /// <param name="nodeValues"> value of the node we want to add</param>
        /// <exception cref="ArgumentNullException"> If the provided array is null</exception>
        public void Add(int[] nodeValues)
        {
            if (nodeValues == null) throw new ArgumentNullException("Invalid null array of elements");
            foreach (int nodeValue in nodeValues) Add(nodeValue);
            
        }

        /// <summary>
        /// Given an integer value, this method will remove the first instace of that value that is found in the Linked List
        /// </summary>
        /// <param name="nodeValue"> integer value of the element to remove</param>
        public void Remove(int nodeValue)
        {
            Node parentNode = null;
            Node actualNode = head;
            if (head == null) return;
            for (int i = 0; i< numberOfElements; i++)
            {
                if (actualNode.value == nodeValue) break;
                else
                {
                    parentNode = actualNode;
                    actualNode = actualNode.Next;
                }
            }
            if (actualNode == null) return;

            _Remove(parentNode, actualNode);
        }
        private void _Remove(Node parent, Node node)
        {
            numberOfElements--;
            if (parent == null) head = node.Next;
            else parent.Next = node.Next;

            node = null;
        }

        /// <summary>
        /// Given a position this method will return the value stored in that position if possible
        /// </summary>
        /// <param name="nodePos"> position of the node</param>
        /// <returns> The value stored in said position</returns>
        /// <exception cref="IndexOutOfRangeException"> when the position is either negative or over the number of elements</exception>
        public int getElement(int nodePos)
        {
            if (nodePos >= NumberOfElements) throw new IndexOutOfRangeException($"Invalid node position for the given size {NumberOfElements}");
            if (nodePos < 0) throw new IndexOutOfRangeException($"Invalid node negative position");
            Node actualNode = head;
            for (int i = 0; i < numberOfElements; i++)
            {
                if (i == nodePos) return actualNode.value;
                else
                {
                    actualNode = actualNode.Next;
                }
            }
            return -1;
        }

        /// <summary>
        /// Property for the number of elements atribute
        /// </summary>
        public int NumberOfElements
        {
            get { return numberOfElements; }
        }
/// <inheritdoc/>

        public override string ToString()
        {
            if (head == null) return string.Empty;
            string str = "";
            Node actualNode = head;
            for (int i = 0; i < numberOfElements; i++)
            {
                str += actualNode.value.ToString() + " - ";
                actualNode = actualNode.Next;
            }
            return str;
        }
    }
}

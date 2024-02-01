using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP.LinkedList
{

    internal class LinkedList
    {
        private Node head;
        private Node tail;
        private int numberOfElements;


        /// <summary>
        /// Constructor given an integer node value that will define the head of the Linked List
        /// </summary>
        /// <param name="headValue"> Ineteger expected to be the value of the head of the linked list</param>
        public LinkedList(int headValue) {
            this.head = new Node(headValue);
            this.tail = head;
            numberOfElements = 1;
        }

        /// <summary>
        /// Constructor that builds a linked list from an array of values
        /// </summary>
        /// <param name="nodesValues">Array contining the values to be inserted </param>
        /// <exception cref="ArgumentNullException"> Thrown when the received array is null</exception>
        public LinkedList(int[] nodesValues) 
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
            Node nextTail = new Node(nodeValue);
            tail.AddLink(nextTail);
            tail = nextTail;
            numberOfElements++;
        }

        /// <summary>
        /// Given an integer value, this method will remove the first instace of that value that is found in the Linked List
        /// </summary>
        /// <param name="nodeValue"> integer value of the element to remove</param>
        public void Remove(int nodeValue)
        {
            Node parentNode = null;
            Node actualNode = head;
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
        /// Given a value, this method will return the frist instance of a node containing that value
        /// </summary>
        /// <param name="nodeValue"> value that we are expecting to find</param>
        /// <returns> The firt Node containing that value.\nNull if the element was not found</returns>
        public Node getElement(int nodeValue)
        {
            Node actualNode = head;
            for (int i = 0; i < numberOfElements; i++)
            {
                if (actualNode.value == nodeValue) return actualNode;
                else
                {
                    actualNode = actualNode.Next;
                }
            }
            return null;
        }

        public int NumberOfElements
        {
            get { return numberOfElements; }
        }
    }
}

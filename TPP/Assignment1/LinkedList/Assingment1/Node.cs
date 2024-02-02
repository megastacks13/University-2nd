using System;

namespace TPP.LinkedList
{
    internal class Node
    {
        internal int value {get;}
        private Node next;

        internal Node Next
        {
            get { return next; }
            set
            {
                next = value;
            }
        }   

        /// <summary>
        /// Constructor for the class node, receiving the value it will have stored. When the node is created their next Node will be set to be null
        /// </summary>
        /// <param name="value"> As the Integer value this node will represent</param>
        internal Node (int value)
        {
            this.value = value;
            next = null;
        }

        /// <summary>
        /// Given a node, this method will assing if possible the 'next' attribute to the Node provided
        /// </summary>
        /// <param name="nextNode"> Node that is expected to follow the tail</param>
        internal void AddLink( Node nextNode)
        {
            Next = nextNode;
        }
    }
}

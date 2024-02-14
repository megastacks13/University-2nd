using System;

namespace TPP.LinkedList
{
    public class Node
    {
        protected Object value { get; }
        private Node next;

        public Object Value { get { return value; } }
        public Node Next
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
        public Node(Object value)
        {
            this.value = value;
            next = null;
        }

        /// <summary>
        /// Given a node, this method will assing if possible the 'next' attribute to the Node provided
        /// </summary>
        /// <param name="nextNode"> Node that is expected to follow the tail</param>
        public void AddLink(Node nextNode)
        {
            Next = nextNode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class LinkedListIterator
    {
        Node currentNode;
        public LinkedListIterator(Node starNode)
        {
            currentNode = starNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public string next()
        {
            string data = currentNode.data;
            currentNode = currentNode.next;

            return data;
        }
    }
}

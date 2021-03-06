using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class LinkedList
    {
        private Node head;
        private Node tail = null;
        private int size;

        public void addAtTail(string data)
        {
            Node node = new Node(data);

            if (size == 0)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.previous = tail;
            }
            tail = node;
            size++;
        }

        public void addAtFront(string data)
        {
            Node node = new Node(data);

            if (size == 0)
            {
                tail = node;
            }
            else
            {
                head.previous = node;
                node.next = head;
            }
            head = node;
            size++;

        }

        public Node findNode(int index)
        {
            if (index < 0 || index > size)
            {
                return null;
            }

            Node node = head;
            int currentIndex = 0;

            while (currentIndex != index)
            {
                currentIndex++;
                node = node.next;
            }

            return node;
        }

        public void remove(int index)
        {
            Node node = findNode(index);

            if (node == null)
            {
                return;
            }
            if (size == 1)
            {
                head = null;
                tail = null;
            }
            else if (node == head)
            {
                head = head.next;
                head.previous = null;
            }
            else if (node == tail)
            {
                tail = tail.previous;
                tail.next = null;
            }
            else
            {
                node.previous.next = node.next;
                node.next.previous = node.previous;
            }

            size--;

        }

        public void removeAll()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void setAt(int index, string data)
        {
            Node node = findNode(index);

            if (node != null)
            {
                node.data = data;
            }
        }

        public string getAt(int index)
        {
            Node node = findNode(index);

            return node == null ? null : node.data;
        }

        public int getSize()
        {
            return size;
        }

        public LinkedListIterator getIterator() => new LinkedListIterator(head);
    }
}

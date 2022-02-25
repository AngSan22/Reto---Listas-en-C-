using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class ArrayList
    {
        private static int DEFAULT_SIZE = 2;
        private string[] array;
        private int size;

        public ArrayList()
        {
            array = new string[DEFAULT_SIZE];
        }

        public ArrayList(int size)
        {
            array = new string[size];
        }

        private void increaseArraySize()
        {
            string[] newArray = new string[array.Length * 2];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public void addAtTail(string data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            array[size] = data;
            size++;
        }

        public void addAtFront(string data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            for (int i = 0; i < size; i++)
            {
                array[i+1] = array[i];
            }

            array[0] = data;
            size++;
        }


        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[size - 1] = null;
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = null;
            }
            size = 0;
        }

        public void setAt(int index, string data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        public string getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : null;
        }

        public int getSize()
        {
            return size;
        }

        public ArrayListIterator getIterator() => new ArrayListIterator(this);
    }
}

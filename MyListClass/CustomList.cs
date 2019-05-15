using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClass
{
    public class CustomList<T>
    {
        //has these
        public T[] workingArray;
        public int Capacity { get { return capacity; } }
        private int capacity;
        public int Count { get { return count; } }
        private int count;

        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            workingArray = new T[capacity];
        }

        //does this
        public void checkCapacity() //break up into SR
        {
            if (count == capacity)
            {
                int prevCapacity = capacity;
                capacity = capacity * 2;
                T[] newArray = new T[capacity];
                Array.Copy(workingArray, 0, newArray, 0, prevCapacity);
                workingArray = newArray;
            }
        }
        public void Add(T item)
        {
            workingArray[count] = item;
            count++;
            checkCapacity();
        }
        public void Remove(T item)
        {
            //workingArray[counter] = 0;
            count--;
        }
    }
}

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
        public T[] startingArray;
        public int capacity;
        public int counter;

        //constructor
        public CustomList()
        {
            counter = 0;
            capacity = 4;
            workingArray = new T[capacity];
        }

        //does this
        public void checkCapacity()
        {
            if (counter == capacity)
            {
                capacity = capacity * 2;
                T[] newArray = new T[capacity];
                Array.Copy(workingArray, 0, newArray, 0, capacity);
                workingArray = newArray;
            }
        }
        public void Add(T item)
        {
            workingArray[counter] = item;
            counter++;
            checkCapacity();
        }
        public void Remove(T item)
        {
            //workingArray[counter] = 0;
            counter--;
        }
    }
}

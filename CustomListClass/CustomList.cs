using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        //has these
        public T[] elements;
        public T[] emptyArray;
        public int size;
        public int Capacity
        {
            get
            {
                return 4;
            }
        }

        public int Count
        {
            get
            {
                return elements.Length;
            }
        }

        //constructor
        public CustomList()
        {
            T[] emptyArray = new T[0];
            elements = emptyArray;
        }
        public CustomList(int capacity)
        {
            if (capacity == 0)
                elements = emptyArray;
            else
                elements = new T[capacity];
        }

        //does this
        public void Add(T item)
        {
            // Adds the given object to the end of this list. The size of the list is
            // increased by one. If required, the capacity of the list is doubled
            // before adding the new element.
            if (size == elements.Length) EnsureCapacity(size + 1);
            elements[size++] = item;
            _version++;
        }

        public void GetSetCount()
        {

        }
        public void Add(T thingToAdd)
        {
            elements[Count + 1] = thingToAdd;
        }
        public void FindCount()
        {

        }
        public void ResizeWhenCountIsCapacity()
        {
            /*If the Count becomes equals to Capacity, then the capacity of the List increased automatically 
             * by reallocating the internal array. The existing elements will be copied to the new array before the 
             * addition of the new element.
            */
        }
    }
}


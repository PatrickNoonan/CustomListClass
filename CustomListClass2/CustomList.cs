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
/*
 * public class CustomList<T>
    {
        //has these
        public T[] elements;
        public T[] emptyArray;
        public int size;
        public int defaultCapacity = 4;
        // Gets and sets the capacity of this list.  The capacity is the size of
        // the internal array used to hold items.  When set, the internal 
        // array of the list is reallocated to the given capacity.

        public int Capacity
        {
            get
            {
                return elements.Length;
            }
            set
            {
                if (value < size)
                {
                    //try catch for out of range exception?
                }

                if (value != elements.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (size > 0)
                        {
                            Array.Copy(elements, 0, newItems, 0, size);
                        }
                        elements = newItems;
                    }
                    else
                    {
                        elements = emptyArray;
                    }
                }
            }
        }
        public int Count
        {
            get
            {
                return size;
            }
        }
        // Sets or Gets the element at the given index.
        // 
        public T this[int index]
        {
            get
            {
                // Following trick can reduce the range check by one
                if (index >= size)
                {
                    //try catch for an exception?
                }
                return elements[index];
            }

            set
            {
                if (index >= size)
                {
                    //possible throw catch for exception?
                }
                elements[index] = value;
            }
        }

        //constructor
        public CustomList()
        {
            size = 0;
            T[] emptyArray = new T[defaultCapacity];
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

            elements[size] = item;

            if (size == elements.Length)
            {
                elements[size++] = item;
            }
        }
        public void Remove(T item)
        {
            //elements[Count - 1] = thingToAdd; 
            if (size == elements.Length)
            {
                elements[size--] = item;
            }
        }
    }
    */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClass
{
    public class CustomList<T> : IEquatable<T>
    {
        //has these
        public T[] workingArray;
        public int Capacity { get { return capacity; } }
        private int capacity;
        public int Count { get { return count; } }
        private int count;

        public T this[int i]
        {
            get
            {
                if (i >= count)
                {
                    throw new IndexOutOfRangeException($"The list can hold only {capacity} elements.");
                }
                return (T)workingArray[i];
            }
            set
            {
                if (i >= count)
                {
                    throw new IndexOutOfRangeException($"The list can hold only {capacity} elements.");
                }
                workingArray[i] = value;
            }
        }

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
                workingArray = newArray;
                for (int i = 0; i < prevCapacity; i++)
                {
                    workingArray[i] = newArray[i];

                }
            }
        }
        public void Add(T item)
        {
            workingArray[count] = item;
            count++;
            checkCapacity();
        }
        /*public void Remove(T[] source, T item)
        {
            int index;
            for (int i = 0; i < capacity; i++)
            {
                item.Equals()
                if (source[i] == item)
                {
                    index = i;
                }
            }

            T[] holderArray = new T[capacity - 1];
            Array.Copy(source, 0, holderArray, 0, capacity, index);

            Array.Copy(source, index + 1, holderArray, index, capacity - index - 1);

            workingArray = holderArray;
            count--;
        }*/
        public void RemoveAt(T[] source, int index)
        {
            T[] holderArray = new T[capacity - 1];
            Array.Copy(source, 0, holderArray, 0, index);

            if (index < capacity - 1)
                Array.Copy(source, index + 1, holderArray, index, capacity - index - 1);

            workingArray = holderArray;
            count--;
        }
        public override string ToString()
        {
            var result = string.Join(" ", workingArray).Trim();
            return result;
        }
        /*public IEnumerator GetEnumerator()
        {
            return workingArray.GetEnumerator();
        }*/
        public bool Equals(T other)
        {
            throw new NotImplementedException();
        }
        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> JoinedCustomList = new CustomList<T>();
            JoinedCustomList = firstList + secondList;
            return JoinedCustomList;
        }
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> JoinedCustomList = new CustomList<T>();
            JoinedCustomList = firstList - secondList;
            return JoinedCustomList;
        }
    }
}

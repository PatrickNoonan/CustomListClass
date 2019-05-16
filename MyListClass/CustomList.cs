using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClass
{
    public class CustomList<T> : IEnumerable, IComparable
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
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return workingArray[i];
            }
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public void checkCapacity() //break up into SR
        {
            if (count == capacity)
            {
                int prevCapacity = capacity;
                capacity = capacity * 2;
                T[] holderArray = new T[capacity];
                for (int i = 0; i < prevCapacity; i++)
                {
                    holderArray[i] = workingArray[i];
                }
                workingArray = holderArray;
            }
        }
        public void Add(T item)
        {
            workingArray[count] = item;
            count++;
            checkCapacity();
        }
        public void Remove(T[] source, T item)
        {
            int index = 0;
            for (int i = 0; i < capacity; i++)
            {
                if (item.Equals(source[i]))
                {
                    index = i;
                    break;
                }
            }

            T[] holderArray = new T[capacity - 1];
            for (int i = 0; i < capacity - 1; i++)
            {
                if (i >= index)
                {
                    holderArray[i] = workingArray[i + 1];
                    if (i == count)
                    {
                        break;
                    }
                    continue;
                }
                holderArray[i] = workingArray[i];
            }
            workingArray = holderArray;
            count--;
        }
        public void RemoveAt(int index)
        {
            T[] holderArray = new T[capacity - 1];
            for (int i = 0; i < capacity - 1; i++)
            {
                if (i >= index)
                {
                    holderArray[i] = workingArray[i + 1];
                    if (i == count)
                    {
                        break;
                    }
                    continue;
                }
                holderArray[i] = workingArray[i];
            }
            workingArray = holderArray;
            count--;
        }
        public override string ToString()
        {
            var result = string.Join(" ", workingArray).Trim();

            return result;
        }
        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> JoinedCustomList = new CustomList<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                JoinedCustomList.Add(firstList.workingArray[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                JoinedCustomList.Add(secondList.workingArray[i]);
            }
            return JoinedCustomList;
        }
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> ReducedCustomList = new CustomList<T>();
            int flag = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i].Equals(secondList[j]))
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    ReducedCustomList.Add(firstList[i]);
                }
                flag = 0;
            }
            return ReducedCustomList;
        }
        public void Zip(CustomList<T> secondList)
        {
            CustomList<T> HolderList = new CustomList<T>();

            int largestCount;
            if (count > secondList.count)
            {
                largestCount = count;
            }
            else
            {
                largestCount = secondList.count;
            }

            for (int i = 0; i < largestCount; i++)
            {
                HolderList.Add(workingArray[i]);
                HolderList.Add(secondList[i]);
            }
            workingArray = HolderList.workingArray;
        }
        public CustomList<int> Sort(int[] arr)
        {
            CustomList<int> SortedList = new CustomList<int>();

            QuickSort(arr, 0, capacity - 1);

            foreach (var item in arr)
            {
                SortedList.Add(item);
            }
            return SortedList;
        }
        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}

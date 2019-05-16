﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> NewCustomList1 = new CustomList<int>();
            CustomList<int> NewCustomList2 = new CustomList<int>();
            CustomList<int> JoinedCustomList;


            //think about this!
            NewCustomList1.Zip(NewCustomList1, NewCustomList2);



            //act - act on the method under test            
            NewCustomList1.Add(1);
            NewCustomList1.Add(3);
            NewCustomList1.Add(5);

            NewCustomList2.Add(2);
            NewCustomList2.Add(1);
            NewCustomList2.Add(6);

            JoinedCustomList = NewCustomList1 - NewCustomList2;
            Console.WriteLine(JoinedCustomList);
            Console.ReadLine();
        }
    }
}

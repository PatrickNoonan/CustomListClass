using System;
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
            for (int i = 9; i > 0; i--)
            {
                NewCustomList1.Add(i);
            }

            NewCustomList1.Sort(NewCustomList1.workingArray);
        }
    }
}

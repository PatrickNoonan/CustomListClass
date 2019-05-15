using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> newCustomList = new CustomList<int>();
            newCustomList.Add(1);
            newCustomList.Add(2);
            newCustomList.Add(3);
            newCustomList.Add(4);

        }
    }
}

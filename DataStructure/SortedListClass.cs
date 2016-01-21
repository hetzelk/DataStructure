using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SortedListClass
    {
        SortedList<int, ICustomString> sortedStringList;
        public SortedListClass()
        {
            sortedStringList = new SortedList<int, ICustomString>();
        }

        public void AddToList(ICustomString customString)
        {
            int count = sortedStringList.Count();
            count++;
            sortedStringList.Add(count, customString);
        }
    }
}

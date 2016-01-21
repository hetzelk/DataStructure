using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SortedListClass
    {
        SortedList<int, ICustomString> sortedStringList;

        public SortedListClass()
        {
            sortedStringList = new SortedList<int, ICustomString>();
        }

        public void AddToList(ICustomString customString)
        {
            sortedStringList.Add(customString.Length(), customString);
        }

        public void Print()
        {
            foreach(KeyValuePair<int, ICustomString> pair in sortedStringList)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
        }
    }
}

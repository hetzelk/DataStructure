using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    interface ICustomString
    {
        string ToString();

        void Insert(string stringToInsert, int insertPosition);

        void Remove(int startIndex, int numCharsToRemove);

        int Length();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SystemString : ICustomString
    {
        string returnString;

        public SystemString(string stringInput)
        {
            returnString = stringInput;
        }

        public override string ToString()
        {
            return returnString;
        }

        public void Insert(string inputString, int insertPosition)
        {
            string newString = returnString.Insert(insertPosition, inputString);
            //Console.WriteLine(newString);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            string newString = returnString.Remove(startIndex, numCharsToRemove);
            //Console.WriteLine(newString);
        }

        public int Length()
        {
            //Console.WriteLine(returnString.Length);
            return returnString.Length;
        }
    }
}

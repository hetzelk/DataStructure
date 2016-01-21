using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SystemArrayString : ICustomString
    {
        char[] charArray;
        char[] removeCharArray;

        public SystemArrayString(string stringInput)
        {
            charArray = stringInput.ToCharArray();
        }

        public override string ToString()
        {
            string returnString = new string(charArray);
            return returnString;
        }

        public void Insert(string stringInput, int insertPosition)
        {
            char[] insertCharArray = stringInput.ToCharArray();
            int charArrayLength = Length();
            int inputCharArrayLength = insertCharArray.Length;
            int total = charArrayLength + inputCharArrayLength;
            char[] newCharArray = new char[total];
            int baseIndexCount = 0;
            for (int index = 0; index < total; index++)
            {
                if (index == insertPosition)
                {
                    for (int count = 0; count < inputCharArrayLength; count++)
                    {
                        newCharArray[index] = insertCharArray[count];
                        index++;
                    }
                }
                newCharArray[index] = charArray[baseIndexCount];
                baseIndexCount++;
            }
            charArray = newCharArray;
            PrintAllInArray(charArray);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int charArrayLength = Length();
            char[] newCharArray = new char[charArrayLength];
            int baseIndexCount = 0;
            for (int index = 0; index < charArrayLength; index++)
            {
                if (index == startIndex)
                {
                    for (int count = 0; count < numCharsToRemove; count++)
                    {
                        index++;
                    }
                }
                newCharArray[baseIndexCount] = charArray[index];
                baseIndexCount++;
            }
            removeCharArray = newCharArray;
            PrintAllInArray(removeCharArray);
        }

        public int Length()
        {
            return charArray.Length;
        }

        public void PrintAllInArray(char[] array)
        {
            foreach (char c in array)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }
}

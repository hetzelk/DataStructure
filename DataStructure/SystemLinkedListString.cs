using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SystemLinkedListString : ICustomString
    {
        string returnString;
        LinkedList<char> linkedList;

        public SystemLinkedListString(string stringInput)
        {
            linkedList = new LinkedList<char>();
            char[] charArray = stringInput.ToCharArray();
            int index = 0;
            foreach(char c in charArray)
            {
                linkedList.AddLast(charArray[index]);
                index++;
            }
            returnString = stringInput;
            PrintEachItem();
        }

        public override string ToString()
        {
            return returnString;
        }

        public void Insert(string inputString, int insertPosition)
        {
            char[] inputCharArray = inputString.ToCharArray();
            LinkedList<char> newLinkedList = new LinkedList<char>();
            int total = inputCharArray.Length + linkedList.Count;
            List<char> charList = new List<char>();
            foreach(char c in linkedList)
            {
                charList.Add(c);
            }
            int baseIndexCounter = 0;
            for (int index = 0; index < total; index++)
            {
                if(index == insertPosition)
                {
                    foreach(char nextChar in inputCharArray)
                    {
                        newLinkedList.AddLast(nextChar);
                        index++;
                    }
                }
                newLinkedList.AddLast(charList[baseIndexCounter]);
                baseIndexCounter++;
            }
            linkedList = newLinkedList;
            PrintEachItem();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            LinkedList<char> newLinkedList = new LinkedList<char>();
            int total = linkedList.Count;
            int baseIndexCount = 0;
            List<char> charList = new List<char>();
            foreach (char c in linkedList)
            {
                charList.Add(c);
            }
            for (int index = 0; index < total; index++)
            {
                if (index == startIndex)
                {
                    for (int count = 0; count < numCharsToRemove; count++)
                    {
                        index++;
                    }
                }
                newLinkedList.AddLast(charList[index]);
                baseIndexCount++;
            }
            linkedList = newLinkedList;
            PrintEachItem();
        }

        public int Length()
        {
            int count = 0;
            foreach(char c in linkedList)
            {
                count++;
            }
            return count;
        }

        public void PrintEachItem()
        {
            foreach (char c in linkedList)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }
}

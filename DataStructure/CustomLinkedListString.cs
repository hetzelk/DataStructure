using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CustomLinkedListString : ICustomString
    {
        public Node head;
        string mainInput;

        public CustomLinkedListString(string stringInput)
        {
            head = new Node();
            mainInput = stringInput;
            CreateList(mainInput, 0);
        }

        public override string ToString()
        {
            char[] allCharacters = GetAllChars();
            string combinedCharacters = new string(allCharacters);
            Console.WriteLine(combinedCharacters);
            return combinedCharacters;
        }

        public void CreateList(string inputString, int insertPosition)
        {
            char[] inputArray = inputString.ToCharArray();
            int total = inputArray.Count();
            Node current = head;
            for (int index = 0; index < total; index++)
            {
                for (int count = 0; count < insertPosition; count++)
                {
                    current = current.next;
                }
                Node newNode = new Node();
                newNode.next = current.next;
                //Console.WriteLine(inputArray[index]);
                newNode.data = inputArray[index];
                current.next = newNode;
            }
            current.data = inputArray[0];
        }

        public void Insert(string inputString, int insertPosition)
        {
            char[] inputArray = inputString.ToCharArray();
            int total = inputArray.Count();
            Node current = head;
            for (int index = 0; index < total; index++)
            {
                for (int count = 0; count < insertPosition; count++)
                {
                    current = current.next;
                }
                Node newNode = new Node();
                newNode.next = current.next;
                //Console.WriteLine(inputArray[index]);
                newNode.data = inputArray[index];
                current.next = newNode;
            }
            current.data = inputArray[0];
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            Node current = head;
            Node nodeRemovedUpTo = head;
            for (int index = 0; index < startIndex - 1; index++)
            {
                current = current.next;
            }
            for (int index = 0; index < numCharsToRemove + startIndex; index++)
            {
                nodeRemovedUpTo = nodeRemovedUpTo.next;
            }
            current.next = nodeRemovedUpTo.next;
        }

        public int Length()
        {
            Node current = head;
            int count = 0;
            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }

        public char[] GetAllChars()
        {
            char[] allCharacters = new char[Length()];
            List<Node> allNodes = new List<Node>();
            Node cur = head;
            while (cur.next != null)
            {
                allNodes.Add(cur);
                cur = cur.next;
            }
            allNodes.Add(cur);
            for (int i = 0; i < allCharacters.Length; i++)
            {
                allCharacters[i] = allNodes[i].data;
            }
            return allCharacters;
        }
    }
}

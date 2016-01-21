using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class CustomLinkedListString : ICustomString
    {
        public Node head;

        public CustomLinkedListString(string stringInput)
        {
            head = new Node();
            createLinkedList(stringInput);
            Console.WriteLine("\nstarttttt");
            Console.WriteLine(Length());//ToString("");
            Console.WriteLine("enddddddddd");
        }

        public void createLinkedList(string stringInput)
        {
            char[] charArray = stringInput.ToCharArray();
            int index = 0;
            Node current = head;
            head.data = charArray[index];
            foreach(char c in charArray)
            {
                Node toAdd = new Node();
                Console.Write(c + " ");
                current.data = charArray[index];
                current.next = toAdd;
                index++;
            }
        }
        
        public override string ToString()
        {
            Console.WriteLine("Start ToString");
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.next.data);
                current = current.next;
                Console.WriteLine("Each should be printed");
            }
            return "";
        }

        public void Insert(string inputString, int insertPosition)
        {
            Node toAdd = new Node();
            char[] charArray = inputString.ToCharArray();
            int index = 0;
            Node current = head;
            while (current.next != null)
            {
                if(index == insertPosition)
                {
                    foreach(char c in charArray)
                    {
                        current.next.data = c;
                        index++;
                    }
                }
                current.next.data = head.next.data;
                index++;
            }
            ToString();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {

        }

        public int Length()
        {
            Node current = head;
            int count = 0;
            while (current.next != null)
            {
                Console.WriteLine("it - " + head.data);
                Console.WriteLine("it - " + current.data);
                current = current.next;
                count++;
            }
            ToString();
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class RunAll
    {
        static string inputString = "abcdefghijklmnopqrstuvwxyz";

        public void Main()
        {
            Console.WriteLine("-----Original String------");
            Console.WriteLine("{0}", inputString);
            Console.WriteLine("--------------------------");
            //RunSString();
            //RunSAString();
            //RunSLList();
            //RunCLString();
            //RunLList();
            Console.WriteLine("\n---End---");
            Console.Read();
        }

        public static void RunSString()
        {
            Console.WriteLine("--------------1---------------");
            SystemString SString = new SystemString(inputString);
            SString.ToString();
            SString.Insert("123!", 3);
            SString.Remove(2, 3);
            SString.Length();
        }

        public static void RunSAString()
        {
            Console.WriteLine("--------------2---------------");
            SystemArrayString SAString = new SystemArrayString(inputString);
            SAString.ToString();
            SAString.Insert("456!", 9);
            SAString.Remove(4, 4);
            Console.WriteLine(SAString.Length());
        }

        public static void RunSLList()
        {
            Console.WriteLine("--------------3---------------");
            SystemLinkedListString SLLString = new SystemLinkedListString(inputString);
            SLLString.ToString();
            SLLString.Insert("789!", 5);
            SLLString.Remove(2, 3);
            SLLString.Length();
        }

        public static void RunCLString()
        {
            Console.WriteLine("--------------4---------------");
            CustomLinkedListString CLString = new CustomLinkedListString(inputString);
            CLString.ToString();
            CLString.Insert("369!", 5);
            CLString.ToString();
            CLString.Remove(2, 3);
            Console.WriteLine(CLString.Length());
        }

        public static void RunLList()
        {
            Console.WriteLine("--------------Sorted List---------------");
            string first = "Hey";
            string second = "This is different";
            string third = "This value = this.";
            SystemString SString = new SystemString(first);
            SystemArrayString SAString = new SystemArrayString(second);
            SystemLinkedListString SLLString = new SystemLinkedListString(third);

            SortedListClass slc = new SortedListClass();
            slc.AddToList(SString);
            slc.AddToList(SAString);
            slc.AddToList(SLLString);
            slc.Print();
        }
    }
}

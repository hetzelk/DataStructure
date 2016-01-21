using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class RunAll
    {
        static string string1 = "Abcdefghijklmnopqrstuvwxyz1";
        static string string2 = "aBcdefghijklmnopqrstuvwxyz2";
        static string string3 = "abCdefghijklmnopqrstuvwxyz3";
        static string string4 = "abcDefghijklmnopqrstuvwxyz";

        public void Main()
        {
            Console.WriteLine("----Original String-----");
            Console.WriteLine("{0} \n{1} \n{2} \n{3}", string1, string2, string3, string4);
            Console.WriteLine("------------------------");
            RunSString();
            RunSAString();
            RunSLList();
            RunCLString();
            Console.WriteLine("End");
            Console.Read();
        }

        public static void RunSString()
        {
            Console.WriteLine("--------------1---------------");
            SystemString SString = new SystemString(string1);
            SString.ToString();
            SString.Insert("123!", 3);
            SString.Remove(2, 3);
            SString.Length();
        }

        public static void RunSAString()
        {
            Console.WriteLine("--------------2---------------");
            SystemArrayString SAString = new SystemArrayString(string2);
            SAString.ToString();
            SAString.Insert("456!", 9);
            SAString.Remove(4, 4);
            Console.WriteLine(SAString.Length());
        }

        public static void RunSLList()
        {
            Console.WriteLine("--------------3---------------");
            SystemLinkedListString SLLString = new SystemLinkedListString(string3);
            SLLString.ToString();
            SLLString.Insert("789!", 5);
            SLLString.Remove(2, 3);
            SLLString.Length();
        }

        public static void RunCLString()
        {
            Console.WriteLine("--------------4---------------");
            CustomLinkedListString CLString = new CustomLinkedListString(string4);
            CLString.ToString();
            CLString.Insert("369!", 5);
            CLString.Remove(2, 3);
            Console.WriteLine(CLString.Length());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Contestant
    {
        string name;
        int numberChoice;

        public Contestant(string nameInput, int numberInput)
        {
            name = nameInput;
            numberChoice = numberInput;
        }

        public string GetName { get { return name; } }

        public int GetNumber { get { return numberChoice; } }
    }
}

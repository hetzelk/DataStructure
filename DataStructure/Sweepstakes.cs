using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Sweepstakes
    {
        string name;
        Dictionary<int, string> sweepstakesDictionary;

        public Sweepstakes(string nameInput)
        {
            name = nameInput;
            sweepstakesDictionary = new Dictionary<int, string>();
        }

        void RegisterContestant(Contestant contestant)
        {
            sweepstakesDictionary.Add(contestant.GetNumber, contestant.GetName);
        }

        string PickWinner()
        {
            string name = "";
            foreach(KeyValuePair<int, string> pair in sweepstakesDictionary)
            {
                name = pair.Value;
            }
            return name;
        }

        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0}, {1}", contestant.GetNumber, contestant.GetName);
        }

        void PrintAllContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, string> pair in sweepstakesDictionary)
            {
                Console.WriteLine("{0}, {1}", contestant.GetNumber, contestant.GetName);
            }
            
        }
    }
}

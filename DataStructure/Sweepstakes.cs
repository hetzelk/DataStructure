using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Sweepstakes
    {
        string name;
        GenericDictionary<int, string> GenericDictionary;
        Dictionary<int, string> sweepstakesDictionary;

        public Sweepstakes(string nameInput)
        {
            name = nameInput;
            GenericDictionary = new GenericDictionary<int, string>();
            sweepstakesDictionary = new Dictionary<int, string>();
        }

        public void SetGenericDictionary()
        {
            GenericDictionary.GetSetGenericDictionary = sweepstakesDictionary;
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

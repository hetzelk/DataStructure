using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class GenericDictionary<Tkey, Tvalue>
    {
        Dictionary<Tkey, Tvalue> GenericSweepstakesDictionary;

        public GenericDictionary()
        {
            GenericSweepstakesDictionary = new Dictionary<Tkey, Tvalue>();
        }
        public Dictionary<Tkey, Tvalue> GetSetGenericDictionary
        {
            get
            {
                return GenericSweepstakesDictionary;
            }
            set
            {
                GenericSweepstakesDictionary = value;
            }
        }
    }
}

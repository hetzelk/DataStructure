using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class GenericDictionary<Tkey, Tvalue>
    {
        Dictionary<Tkey, Tvalue> GensweepstakesDictionary;

        public GenericDictionary()
        {
            GensweepstakesDictionary = new Dictionary<Tkey, Tvalue>();
        }
        public Dictionary<Tkey, Tvalue> GetSetGenericDictionary
        {
            get
            {
                return GensweepstakesDictionary;
            }
            set
            {
                GensweepstakesDictionary = value;
            }
        }
    }
}

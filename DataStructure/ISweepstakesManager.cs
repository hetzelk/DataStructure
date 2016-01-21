using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes<int, string> sweepstakes);

        Sweepstakes<int, string> GetNextSweepstakesWinner();
    }
}

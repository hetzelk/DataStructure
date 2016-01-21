using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepStack;

        public SweepstakesQueueManager()
        {
            sweepStack = new Stack<Sweepstakes>();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStack.Push(sweepstakes);
        }

        Sweepstakes ISweepstakesManager.GetNextSweepstakesWinner()
        {
            return sweepStack.Last();
        }
    }
}

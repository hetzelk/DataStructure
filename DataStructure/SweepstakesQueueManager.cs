using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepStack;

        public SweepstakesQueueManager()
        {
            sweepStack = new Queue<Sweepstakes>();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStack.Enqueue(sweepstakes);
        }

        Sweepstakes ISweepstakesManager.GetNextSweepstakesWinner()
        {
            return sweepStack.Dequeue();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepStack;

        public SweepstakesStackManager()
        {
            sweepStack = new Stack<Sweepstakes>();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStack.Push(sweepstakes);
        }

        Sweepstakes ISweepstakesManager.GetNextSweepstakesWinner()
        {
            return sweepStack.Pop();
        }
    }
}

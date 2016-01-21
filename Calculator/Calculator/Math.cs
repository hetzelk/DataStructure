using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math
    {
        public int Add(int first, int second)
        {
            int answer = first + second;
            return answer;
        }

        public int Subtract(int first, int second)
        {
            int answer = first - second;
            return answer;
        }

        public int Multiply(int first, int second)
        {
            int answer = first * second;
            return answer;
        }

        public int Divide(int first, int second)
        {
            int answer = first / second;
            return answer;
        }
    }
}

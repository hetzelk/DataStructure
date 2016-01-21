using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Subtraction : Math
    {
        public int Start(string input)
        {
            string[] inputArray = input.Split('-');
            int answer = SubtractBoth(inputArray);
            return answer;
        }

        public int SubtractBoth(string[] numbers)
        {
            int first = Convert.ToInt32(numbers[0]);
            int second = Convert.ToInt32(numbers[1]);
            int answer = Subtract(first, second);
            return answer;
        }
    }
}

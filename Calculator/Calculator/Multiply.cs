using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Multiply : Math
    {
        public int Start(string input)
        {
            string[] inputArray = input.Split('*');
            int answer = MultiplyBoth(inputArray);
            return answer;
        }

        public int MultiplyBoth(string[] numbers)
        {
            int first = Convert.ToInt32(numbers[0]);
            int second = Convert.ToInt32(numbers[1]);
            int answer = Multiply(first, second);
            return answer;
        }
    }
}

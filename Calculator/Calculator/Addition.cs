using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition : Math
    {
        public int Start(string input)
        {
            string[] inputArray = input.Split('+');
            int answer = AddBoth(inputArray);
            return answer;
        }

        public int AddBoth(string[] numbers)
        {
            int first = Convert.ToInt32(numbers[0]);
            int second = Convert.ToInt32(numbers[1]);
            int answer = Add(first, second);
            return answer;
        }
    }
}

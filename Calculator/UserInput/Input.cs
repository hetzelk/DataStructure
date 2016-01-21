using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace UserInput
{
    class Input
    {
        Addition add;
        Subtraction minus;
        Multiply mult;
        Division div;

        public Input()
        {
            add = new Addition();
            minus = new Subtraction();
            mult = new Multiply();
            div = new Division();
        }

        public void Main()
        {
            string input = AskForInput();
            string inputOperator = DecidePath(input);
            int answer = 0;
            if (inputOperator == "+" || inputOperator == "-" || inputOperator == "*" || inputOperator == "/")
            {
            answer = ChangePath(inputOperator, input);
            }
            else
            {
                Console.WriteLine("Error, End.");
            }
            Console.WriteLine("Answer:" + answer);
        }

        public string AskForInput()
        {
            Console.WriteLine("Enter a sinmple math operator. ");
            Console.WriteLine("Ex. 2+5 ");
            Console.WriteLine("Ex. 2-5 ");
            Console.WriteLine("Ex. 2*5 ");
            Console.WriteLine("Ex. 2/5 ");
            string input = Console.ReadLine();
            return input;
        }

        public string DecidePath(string input)
        {
            if (input.Contains("+"))
            {
                return "+";
            }
            else if(input.Contains("-"))
            {
                return "-";
            }
            else if (input.Contains("*"))
            {
                return "*";
            }
            else if (input.Contains("/"))
            {
                return "/";
            }
            else
            {
                Console.WriteLine("The operator or numbers you entered is not recognized. ");
            }
            return "+";
        }

        public int ChangePath(string operatorChoice, string input)
        {
            int answer = 0;
            switch (operatorChoice)
            {
                case "+":
                    answer = add.Start(input);
                    break;
                case "-":
                    answer = minus.Start(input);
                    break;
                case "*":
                    answer = mult.Start(input);
                    break;
                case "/":
                    answer = div.Start(input);
                    break;
            }
               return answer;
        }
    }
}

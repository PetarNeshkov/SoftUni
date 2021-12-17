using System;
using System.Collections.Generic;
using System.Linq;

namespace Shouting_yard_algorithm_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 + 4 * 2 / ( 1 - 5 )
            // 3 + 4 * 2 - ( 1 - 5 )
            Console.WriteLine(RPNCalculator(ShoutingYard(Console.ReadLine())));
        }
        private static int PerformOperation(string currElement, int first, int second)
        {
            switch (currElement)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    return first / second;
                default:
                    break;
            }
            throw new ArgumentException();
        }
        static string RPNCalculator(string input)
        {
            string[] expression = input.Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(expression);

            while (stack.Count > 2)
            {
                PrintStack(stack);

                List<string> elements = new List<string>();
                var currElement = stack.Pop();
                while (!IsOperator(currElement))
                {
                    elements.Add(currElement);
                    currElement = stack.Pop();
                }
                int first = int.Parse(elements[elements.Count - 2]);
                int second = int.Parse(elements[elements.Count - 1]);

                int result = PerformOperation(currElement, first, second);
                 
                stack.Push(result.ToString());

                for (int i = elements.Count-3; i >=0; i--)
                {
                    stack.Push(elements[i]);
                }
               
            }
            return stack.Pop();
        }
        static void PrintStack(Stack<string> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static string ShoutingYard(string input)
        {
            string[] expression =input.Split();

            Stack<string> operatorStack = new Stack<string>();

            string output = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (IsOperator(expression[i]))
                {
                    if (operatorStack.Count > 0)
                    {
                        var ElementArity = OperatatorPrecedence(operatorStack.Peek());

                        var oldElementArity = OperatatorPrecedence(expression[i]);
                        if (oldElementArity >= ElementArity)
                        {
                            output += operatorStack.Pop() + " ";
                        }
                    }
                    operatorStack.Push(expression[i]);

                }
                else if (expression[i] == "(")
                {
                    operatorStack.Push(expression[i]);
                }
                else if (expression[i] == ")")
                {
                    while (operatorStack.Peek() != "(")
                    {
                        output += operatorStack.Pop() + " ";
                    }
                    operatorStack.Pop();
                }
                else
                {
                    output += expression[i] + " ";
                }
            }
            while (operatorStack.Count > 0)
            {
                output += operatorStack.Pop() + " ";
            }
            return output;
        }
        static int OperatatorPrecedence(string input)
        {
            switch (input)
            {
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "*":
                    return 3;
                case "/":
                    return 3;
                case "(":
                    return 1;
                default:
                    break;
            }
            throw new ArgumentException();
        }
        static bool IsOperator(string input)
        {
            switch (input)
            {
                case "+":
                    return true;
                case "-":
                   return true;
                case "*":
                    return true;
                case "/":
                    return true;
                default:
                    break;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;

namespace CalculatorIdeagenTechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = "1 + 1";
            var test = expression.Split(" ");
            Console.WriteLine(test);
            Console.WriteLine(Calculate(expression));
        }
        /// <summary>
        /// Other Solution
        /// Can use tree algorithm or stack but need to rearrange the equation to prefix/postfix first
        /// Comment: since this one im not remember how to use it and i cant googling it,
        /// i think i wanna try design other logic using pseudocode.
        /// Important!!!
        /// HackerRank profile: https://www.hackerrank.com/ammar_aziz
        /// i got used HackerRank to test my logical think, maybe can review if u free
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static double Calculate(string expression)
        {
            List<double> numbers = new List<double>();
            
            //TODO Test Case 1
            // 1 x 2 + 2 / 2 - 3 (4 symbols = 4 steps)
            //Step 1: (1 x 2) + 2 / 2 - 3
            //Step 2: 2 + (2/2) - 3
            //Step 3: 2 + 1 - 3
            //Step 4: 3 - 3
            //Answer: 0
            
            //TODO Test Case 2
            // 1 x 4 - 4 + 6 / 3 - 3 + 7 (6 symbols = 6 steps)
            //Step 1: (1 x 4) - 4 + 6 / 3 - 3 + 7
            //Step 2: 4 - 4 + 6 / 3 - 3 + 7
            //Step 3: 4 - 4
            //Step 4: 3 - 3
            //Answer: 0
            var items = expression.Split(" ");

            foreach (var item in items)
            {
                switch (item)
                {
                    case "+":
                        // code block
                        break;
                    case "-":
                        // code block
                        break;
                    case "/":
                        // code block
                        break;
                    case "*":
                        // code block
                        break;
                    default:
                        var number = double.Parse(item);
                        numbers.Add(number);
                        break;
                }
            }

            var a = 1;
            return 10;
        }
    }
}
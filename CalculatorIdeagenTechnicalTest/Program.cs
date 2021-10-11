using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorIdeagenTechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = "1 + 1 + 2";
            Console.WriteLine(Calculate(expression));
        }
        /// <summary>
        /// Other Solution
        /// Can use tree algorithm or stack but need to rearrange the equation to prefix/postfix first
        /// Comment: since this one im not remember how to use it and i cant googling it,
        /// i think i wanna try design other logic using pseudocode.
        /// HackerRank profile: https://www.hackerrank.com/ammar_azi
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
            //Step 2: 4 - 4 + (6 / 3) - 3 + 7
            //Step 3: (4 - 4) + 2 - 3 + 7
            //Step 4: 0 + (2 - 3) + 7
            //Step 5: 0 + (-1 + 7)
            //Step 6: 0 + 6
            //Answer: 6
            
            //TODO Test Case 3
            // 1 x 7 - 4 - 6 / 2 + 2 (5 symbols = 5 steps)
            //Step 1: (1 x 7) - 4 - 6 / 2 + 2
            //Step 2: 7 - 4 - (6 / 2) + 2
            //Step 3: (7 - 4) - 3 + 2
            //Step 4: (3 - 3) + 2
            //Step 5: 0 + 2
            //Answer: 2
            
            //Pseudocode
            //1. Count steps, each symbol assume 1 step
            //2. Finish multiply or divide first
            //3. finish subtract and addition
            
            var items = expression.Split(" ").ToList();
            var steps = items.Count / 2;
            
            for (int i = 0; i < steps; i++)
            {
                for (int j = 0; j < items.Count; j++)
                {
                    if (items[j] == "x" )
                    {
                        // 1 x 3
                        //take index before and after "x" and calculate
                        var index = j;
                        var x = Double.Parse(items[j - 1]);
                        var y = Double.Parse(items[j + 1]);
                        var calculate = x * y;
                        items.Insert(j - 1, calculate.ToString());
                        items.RemoveAt(j);
                        items.RemoveAt(j+1);
                    }

                    if (items[j] == "/")
                    {
                        var index = j;
                        var x = Double.Parse(items[j - 1]);
                        var y = Double.Parse(items[j + 1]);
                        var calculate = x / y;
                        items.Insert(j - 1, calculate.ToString());
                        items.RemoveAt(j);
                        items.RemoveAt(j+1);
                    }
                    
                    if (items[j] == "+" )
                    {
                        // 1 x 3
                        //take index before and after "x" and calculate
                        var index = j;
                        var x = Double.Parse(items[j - 1]);
                        var y = Double.Parse(items[j + 1]);
                        var calculate = x + y;
                        items.Insert(j - 1, calculate.ToString());
                        items.RemoveAt(j);
                        items.RemoveAt(j+1);
                    }
                    
                    if (items[j] == "-" )
                    {
                        // 1 x 3
                        //take index before and after "x" and calculate
                        var index = j;
                        var x = Double.Parse(items[j - 1]);
                        var y = Double.Parse(items[j + 1]);
                        var calculate = x - y;
                        items.Insert(j - 1, calculate.ToString());
                        items.RemoveAt(j);
                        items.RemoveAt(j+1);
                    }
                }
            }
            if (items.Count==2)
            {
                return Double.Parse(items[0]);
            }
            // foreach (var item in items)
            // {
            //     switch (item)
            //     {
            //         case "+":
            //             // code block
            //             break;
            //         case "-":
            //             // code block
            //             break;
            //         case "/":
            //             // code block
            //             break;
            //         case "*":
            //             // code block
            //             break;
            //         default:
            //             var number = double.Parse(item);
            //             numbers.Add(number);
            //             break;
            //     }
            // }

            return -1;
        }
    }
}
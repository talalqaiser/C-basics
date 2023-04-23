// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice 
{
    class MiniCalculator 
    {
        static void Main(string[] args) 
        {
            Console.Write("Please enter first number for calculation: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second number for calculation: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the operator from +,-,*,/,% ");
            string op = Console.ReadLine();
            Console.WriteLine("Your result is: " + Calculator(op, num1, num2));
        }
        static double Calculator(string op, double num1, double num2)
        {
            double result;
            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else if (op == "%")
            {
                result = num1 % num2;
            }
            else
            {
                result = 0.0;
                Console.WriteLine("Invalid Operator");
            }


            return result;
        }
    }

}
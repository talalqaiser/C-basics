// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter base number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power number: ");
            int powNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your result is: " + PowerFunction(baseNum, powNum));
        }
        static int PowerFunction(int basNum, int powNum) {
            int result = 1;
            for (int i = 0; i < powNum; i++) { 
                result *= basNum;
            }

            return result;
        
        }
    }
}

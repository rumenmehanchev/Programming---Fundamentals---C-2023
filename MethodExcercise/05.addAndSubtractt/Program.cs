using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.addAndSubtractt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int result = GetResultBetWeenSumAndThirdNum(numOne,numTwo,numThree);
            Console.WriteLine(result);

        }
        static int GetSumFromNumOneAndNumTwo(int num1, int num2)
        {
            int result = 0;
            result += num1 + num2;
            return result;
        }

        static int GetResultBetWeenSumAndThirdNum(int num1, int num2, int num3)
        {
            int diffrent = 0;
            diffrent = GetSumFromNumOneAndNumTwo(num1, num2) - num3;
            return diffrent;
        }
    }
}

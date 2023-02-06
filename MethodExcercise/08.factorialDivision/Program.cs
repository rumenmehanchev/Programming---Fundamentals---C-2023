using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_division
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double finalResult = GetResult(first, second);
            Console.WriteLine($"{finalResult:F2}");


        }

        static double FirstFactorial(double first) 
        {
            double factorial = 1;
            double current = 0;

            for (double nums = 1; nums <= first; nums++)
            {
                current = nums;
                factorial *= current;
            }
            return factorial;
        }
        static double SecondsFactorial(double second)
        {
            double factorial = 1;
            double current = 0;

            for (double nums = 1; nums <= second; nums++)
            {
                current = nums;
                factorial *= current;
            }
            return factorial;
        }
        static double GetResult(double numOne, double numTWo)
        {
            double result = 0;
            result = FirstFactorial(numOne) / SecondsFactorial(numTWo);
            return result;
        }
    }
}
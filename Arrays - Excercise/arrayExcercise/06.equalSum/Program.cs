using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.equalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            bool isEqual = false;
            int index = 0;

            if (number.Length == 1)
            {
                Console.WriteLine($"{0}");
                return;

            }
            for (int i = 0; i < number.Length; i++)
            {
                int leftSum = 0;
                int rigtSum = 0;
                for (int l = 0; l < i; l++)
                {
                    leftSum += number[l];
                }
                for (int r = i + 1; r < number.Length; r++)
                {
                    rigtSum += number[r];
                }
                if (leftSum == rigtSum)
                {
                    isEqual = true;
                    index = i;
                }
            }
            if (isEqual)
            {
                Console.WriteLine($"{index}");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

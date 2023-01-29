using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.magicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
           .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < number.Length; i++)
            {
                int currrentNum = number[i];

                for (int j = i+1; j < number.Length; j++)
                {
                    int nextNum = number[j];


                    if (currrentNum + nextNum == n)
                    {
                        Console.WriteLine($"{currrentNum} {nextNum}");
                    }
                }
            }
        }
    }
}

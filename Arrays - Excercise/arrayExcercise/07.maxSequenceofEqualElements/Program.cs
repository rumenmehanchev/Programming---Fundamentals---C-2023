using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.maxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] number = Console.ReadLine()
            .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();


            //  0 1 1 5 2 2 6 3 3 --> elementi
            //  0 1 2 3 4 5 6 7 8  --> indeksi

            int length = 1;
            int bestLenth = 1;
            int index = 0;

            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] == number[i+1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    
                }

                if (length > bestLenth)
                {
                    bestLenth = length;
                    index = i;
                }
            }


            for (int i = 0; i < bestLenth; i++)
            {
                Console.Write(number[index] + " ");
            }

        }
    }
}

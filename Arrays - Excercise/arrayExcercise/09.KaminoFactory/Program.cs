using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthSequence = int.Parse(Console.ReadLine());
            string command;

            // 1!0!1!1!0
            int finalLength = 1;
            int bestIndex = 0;
            int bestSum = 0;
            int[] bestDNA = new int[lengthSequence];
            int bestSample = 0;
            int sample = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] sequence = command
                    .Split('!', (char)StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sample++;
                // 1 0 1 1 0 --> elementi 
                // 0 1 2 3 4 --> indeksi
                int length = 1;
                int bestCurrentLength = 1;
                int index = 0;
                int sum = 0;

                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] == sequence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        index = i;
                    }
                    sum += sequence[i];
                }
                sum += sequence[sequence.Length - 1];

                if (bestCurrentLength > finalLength)
                {
                    finalLength = bestCurrentLength;
                    bestIndex = index;
                    bestSum = sum;
                    bestSample = sample;
                    bestDNA = sequence.ToArray();
                }
                else if (bestCurrentLength == finalLength)
                {
                    if (index < bestIndex)
                    {
                        finalLength = bestCurrentLength;
                        bestIndex = index;
                        bestSum = sum;
                        bestSample = sample;
                        bestDNA = sequence.ToArray();
                    }
                    else if (bestIndex == index)
                    {
                        if (sum > bestSum)
                        {
                            finalLength = bestCurrentLength;
                            bestIndex = index;
                            bestSum = sum;
                            bestSample = sample;
                            bestDNA = sequence.ToArray();
                        }
                    }

                }

            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestDNA));
        }
    }
}

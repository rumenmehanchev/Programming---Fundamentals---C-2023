using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.topIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int[] topIntegers = new int[number.Length];
            int index = 0;

            // 1 4 3 2 --> elementi
            // 0 1 2 3 --> indeksi

            for (int i = 0; i < number.Length; i++)
            {
                int currentElement = number[i];
                bool isTopinteger = true;

                for (int j = i + 1; j < number.Length; j++)
                {
                    int nextElement = number[j];

                    if (nextElement >= currentElement)
                    {
                        isTopinteger = false;
                        break;
                    }
                }
                if (isTopinteger)
                {
                    topIntegers[index] = currentElement;
                    index++;
                }

            }


            for (int i = 0; i < index; i++)
            {
                Console.Write(topIntegers[i] + " ");
            }

        }
    }
}

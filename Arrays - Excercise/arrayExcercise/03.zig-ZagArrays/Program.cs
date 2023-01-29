using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] evenNumber = new int[n];  
            int[] oddNumber = new int[n];  


            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine()
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int numberOne = array[0];
                int numberTwo = array[1];

                if (i % 2 == 0)
                {
                    evenNumber[i] = numberOne;
                    oddNumber[i] = numberTwo;
                }
                else
                {
                    evenNumber[i] = numberTwo;
                    oddNumber[i] = numberOne;
                }

            }
            Console.WriteLine(String.Join(" ",evenNumber));
            Console.WriteLine(String.Join(" ", oddNumber));

        }
    }
}

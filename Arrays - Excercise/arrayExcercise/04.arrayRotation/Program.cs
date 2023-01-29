using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.arrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int[] array = Console.ReadLine()
                .Split(' ',(char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotation = int.Parse(Console.ReadLine());
            // 51 47 32 61 21
            // 47 32 61 21 51  // Edna rotaciq 

            int reduceRotation = rotation % array.Length;

            for (int i = 0; i < reduceRotation; i++)
            {
                int firstElement = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];

                }
                array[array.Length - 1] = firstElement;
            }


            Console.WriteLine(String.Join(" ",array));
        }
    }
}

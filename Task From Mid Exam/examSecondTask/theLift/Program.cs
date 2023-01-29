using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tourist = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    if (tourist >= 4 - lift[i])
                    {
                        tourist = tourist - (4 - lift[i]);
                        lift[i] = 4;
                    }
                    else
                    {
                        lift[i] += tourist;
                        tourist = 0;
                    }
                }
            }
            bool isNotFull = false;

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    isNotFull = true;
                    break;
                }
            }

            if (tourist == 0 && isNotFull)
            {

                Console.WriteLine("The lift has empty spots!");
            }
            else if (tourist > 0 && !isNotFull)
            {
                Console.WriteLine($"There isn't enough space! {tourist} people in a queue!");
            }

            Console.WriteLine(String.Join(" ", lift));
        }
    }
}

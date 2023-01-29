using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ladyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] ladyBugsIndexes = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int index = 0; index < field.Length; index++)
            {
                if (ladyBugsIndexes.Contains(index))
                {
                    field[index] = 1;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                int initialIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (initialIndex < 0 || initialIndex >= field.Length)
                {
                    continue;
                }
                if (field[initialIndex] == 0)
                {
                    continue;
                }

                field[initialIndex] = 0;
                int nextIndex = initialIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }
                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        break;
                    }
                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }

            }
            Console.WriteLine(string.Join(" ", field));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command;
            int counterShoot = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int indexToShoot = int.Parse(command);

                if (indexToShoot >= 0 && indexToShoot < targets.Length && targets[indexToShoot] != -1)
                {
                    counterShoot++;
                    int valueOftarget = targets[indexToShoot];
                    targets[indexToShoot] = -1;
                   

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }
                        if (targets[i] > valueOftarget)
                        {
                            targets[i] -= valueOftarget;
                        }
                        else
                        {
                            targets[i] += valueOftarget;
                        }
                    }

                }

            }
            Console.WriteLine($"Shot targets: {counterShoot} -> {string.Join(" ", targets)}");

        }
    }
}

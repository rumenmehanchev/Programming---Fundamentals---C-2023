using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2arrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArrValues = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)    
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command
                    .Split(' ');

                string action = tokens[0];
                if (action == "swap")
                {
                    int elementOnIndex1 = int.Parse(tokens[1]);
                    int elementOnIdex2 = int.Parse(tokens[2]);
                
                    int element1 = initialArrValues[elementOnIndex1];
                    int element2 = initialArrValues[elementOnIdex2];
                    initialArrValues[elementOnIndex1] = element2;
                    initialArrValues[elementOnIdex2] = element1;

                }
                else if (action == "multiply")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    int result = 0;

                    result += initialArrValues[index1] * initialArrValues[index2];
                    initialArrValues[index1] = result;
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < initialArrValues.Length; i++)
                    {
                        int currentElement = initialArrValues[i];
                        currentElement--;
                        initialArrValues[i] = currentElement;
                    }
                }

            }

            Console.WriteLine(string.Join(", ", initialArrValues));
        }
    }
}

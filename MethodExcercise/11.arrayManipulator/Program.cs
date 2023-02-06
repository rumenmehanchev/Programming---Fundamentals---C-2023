using System;
using System.Linq;

namespace P11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ');

                string cmdType = cmdArgs[0];
                if (cmdType == "exchange")
                {
                    int exchangeIndex = int.Parse(cmdArgs[1]);
                    if (exchangeIndex < 0 || exchangeIndex >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers = ExchangeArray(numbers, exchangeIndex);
                }
                else if (cmdType == "max" || cmdType == "min")
                {
                    string oddOrEven = cmdArgs[1];

                    int index;
                    if (cmdType == "max")
                    {
                        index = MaxElementOfTypeIndex(numbers, oddOrEven);
                    }
                    else
                    {
                        index = MinElementOfTypeIndex(numbers, oddOrEven);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string oddOrEven = cmdArgs[2];
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (cmdType == "first")
                    {
                        PrintFirstElementOfType(numbers, count, oddOrEven);
                    }
                    else
                    {
                        PrintLastElementOfType(numbers, count, oddOrEven);
                    }
                }

            }
            Console.WriteLine(ArrayToStringFormat(numbers, numbers.Length));
            // print final
        }
        // method

        static int[] ExchangeArray(int[] numbers, int index)
        {
            int[] exchangeArr = new int[numbers.Length];
            int exchangeIndex = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchangeArr[exchangeIndex++] = numbers[i];
            }
            for (int i = 0; i <= index; i++)
            {
                exchangeArr[exchangeIndex++] = numbers[i];

            }
            return exchangeArr;
        }
        static int MaxElementOfTypeIndex(int[] numbers, string oddOrEven)
        {
            int index = -1;
            int maxValue = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currElement = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currElement % 2 == 0 && currElement >= maxValue)
                    {
                        maxValue = currElement;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currElement % 2 != 0 && currElement >= maxValue)
                    {
                        maxValue = currElement;
                        index = i;
                    }
                }

            }
            return index;
        }
        static int MinElementOfTypeIndex(int[] numbers, string oddOrEven)
        {
            int index = -1;
            int minvalue = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currElement = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currElement % 2 == 0 && currElement <= minvalue)
                    {
                        minvalue = currElement;
                        index = i;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currElement % 2 != 0 && currElement <= minvalue)
                    {
                        minvalue = currElement;
                        index = i;
                    }
                }

            }
            return index;
        }
        static void PrintFirstElementOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] firstElement = new int[count];
            int firstIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && firstIndex < count)
                    {
                        firstElement[firstIndex++] = currentNum;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && firstIndex < count)
                    {
                        firstElement[firstIndex++] = currentNum;
                    }
                }
            }

            Console.WriteLine(ArrayToStringFormat(firstElement, firstIndex));
        }

        static void PrintLastElementOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] lastElement = new int[count];
            int lastIndex = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && lastIndex < count)
                    {
                        lastElement[lastIndex++] = currentNum;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && lastIndex < count)
                    {
                        lastElement[lastIndex++] = currentNum;
                    }
                }
            }
            int[] reverceArray = new int[lastElement.Length];
            int reverseIndex = 0;
            for (int i = lastIndex - 1; i >= 0; i--)
            {
                reverceArray[reverseIndex++] = lastElement[i];
            }


            Console.WriteLine(ArrayToStringFormat(reverceArray, reverseIndex));
        }


        static string ArrayToStringFormat(int[] numbers, int count)
        {
            string output = string.Empty;
            output += "[";

            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    output += ($"{numbers[i]}");
                }
                else
                {
                    output += ($"{numbers[i]}, ");
                }
            }
            output += "]";
            return output;
        }
    }
}
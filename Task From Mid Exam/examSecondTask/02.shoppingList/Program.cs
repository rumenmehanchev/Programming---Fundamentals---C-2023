using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.shoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] foodList = Console.ReadLine()
                .Split('!', (char)StringSplitOptions.RemoveEmptyEntries);

            // Tomatoes!Potatoes!Bread

            string command;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs.Contains("Urgent"))
                {
                    string item = cmdArgs[1];

                    for (int i = 1; i < foodList.Length; i++)
                    {
                        if (foodList.Contains(item))
                        {
                           break;
                        }
                        else
                        {
                            string newList = item + " " + string.Join(" ", foodList);
                            foodList = newList.Split(' ');
                        }
                    }
                }
                else if (cmdArgs.Contains("Unnecessary"))
                {
                    string item = cmdArgs[1];
                    int repeatItem = 0;
                    int index = 0;
                    if (foodList.Contains(item))
                    {
                        for (int i = 0; i < foodList.Length; i++)
                        {
                            if (foodList[i] == item)
                            {
                                index = i;
                                repeatItem++;
                                break;
                            }
                        }
                        for (int i = index; i < foodList.Length -1; i++)
                        {
                            foodList[i] = foodList[i + 1];
                        }

                        string[] tempChest = new string[foodList.Length - repeatItem];
                        for (int i = 0; i < tempChest.Length; i++)
                        {
                            tempChest[i] = foodList[i];
                        }
                        foodList= tempChest;

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArgs.Contains("Correct"))
                {
                    string oldItem = cmdArgs[1];
                    string newItem = cmdArgs[2];

                    if (foodList.Contains(oldItem))
                    {
                        for (int i = 0; i < foodList.Length; i++)
                        {
                            if (foodList[i] == oldItem)
                            {
                                foodList[i] = newItem;
                            }
                        }
                    }
                }
                else if (cmdArgs.Contains("Rearrange"))
                {
                    string item = cmdArgs[1];
                    int index = 0;
                    if (foodList.Contains(item))
                    {
                        for (int i = 0; i < foodList.Length; i++)
                        {
                            if (foodList[i] == item)
                            {
                                index = i;
                            }
                        }
                        for (int i = index; i < foodList.Length - 1; i++)
                        {
                            foodList[i] = foodList[i + 1];
                        }
                        foodList[foodList.Length - 1] = item;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", foodList));
        }
    }
}

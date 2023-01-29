using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] treasureChest = Console.ReadLine()
                .Split('|', (char)StringSplitOptions.RemoveEmptyEntries);  // първоначалната плячка от сандъка със съкровището, 

            // Gold|Silver|Bronze|Medallion|Cup 

            string command;

            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] tokens = command
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Contains("Loot"))
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        if (treasureChest.Contains(tokens[i]))
                        {
                            continue;
                        }
                        else
                        { // Поставете предметите в началото на сандъка.   Ако даден елемент вече се съдържа, не го вмъквайте.

                            string newChest = tokens[i] + " " + String.Join(" ", treasureChest); // Dobavqme elementa kam masiva v nachaloto  s tozi red
                            treasureChest = newChest.Split(' ');                                 // posle setvame noviq masiv kam stariq 
                        }
                    }
                }
                else if (tokens.Contains("Drop"))
                {
                    int position = int.Parse(tokens[1]);
                    if (position >= 0 && position < treasureChest.Length)  //  Ако индексът е невалиден, пропуснете командата.
                    {
                        string dropItem = treasureChest[position];  // Премахнете плячката на дадената позиция и я добавете в края на сандъка със съкровището.

                        for (int i = position; i < treasureChest.Length - 1; i++)
                        {
                            treasureChest[i] = treasureChest[i + 1];
                        }
                        treasureChest[treasureChest.Length - 1] = dropItem;
                    }
                }
                else if (tokens.Contains("Steal"))
                {
                    int numberOfSteealingItems = int.Parse(tokens[1]); // Broqt Otkradnati Elementi

                    if (numberOfSteealingItems >= 0 && numberOfSteealingItems < treasureChest.Length)
                    {
                        for (int i = 0; i < numberOfSteealingItems; i++)
                        {
                            Console.Write(treasureChest[treasureChest.Length - numberOfSteealingItems + i]);
                            if (i != numberOfSteealingItems - 1)
                            {
                                Console.Write(", ");
                            }
                        }

                        string[] tempChest = new string[treasureChest.Length - numberOfSteealingItems];
                        for (int i = 0; i < tempChest.Length; i++)
                        {
                            tempChest[i] = treasureChest[i];
                        }
                        treasureChest = tempChest;
                    }
                    else if (numberOfSteealingItems >= 0)
                    {
                        for (int i = 0; i < treasureChest.Length; i++)
                        {
                            Console.Write(treasureChest[i]);
                            if (i != treasureChest.Length - 1)
                            {
                                Console.Write(", ");
                            }
                        }
                        treasureChest = new string[0];
                    }
                    Console.WriteLine();
                    break;
                }

            }
            string treasureCount = String.Join("", treasureChest);
            int charCounter = 0;
            for (int i = 0; i < treasureCount.Length; i++)
            {
                charCounter++;
            }
            double average = (1.0 * charCounter) / treasureChest.Length;
            if (charCounter > 0)
            {
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}

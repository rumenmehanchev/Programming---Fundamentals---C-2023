using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace muOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mazeRooms = Console.ReadLine()
                .Split('|', (char)StringSplitOptions.RemoveEmptyEntries);

            int initialHealt = 100;
            int bitcoins = 0;

            for (int i = 0; i < mazeRooms.Length; i++)
            {
                string[] tokens = mazeRooms[i]
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Contains("potion"))
                {
                    int healthToHeal = int.Parse(tokens[1]);
                    initialHealt += healthToHeal;
                    if (initialHealt > 100)
                    {
                        healthToHeal =  100 - (initialHealt - healthToHeal);
                        initialHealt = 100;
                        
                       
                    }                                                
                    Console.WriteLine($"You healed for {healthToHeal} hp.");
                    Console.WriteLine($"Current health: {initialHealt} hp.");

                }
                else if (tokens.Contains("chest"))
                {
                    int findBitCoins = int.Parse(tokens[1]);
                    Console.WriteLine($"You found {findBitCoins} bitcoins.");
                    bitcoins += findBitCoins;
                }
                else
                {
                    int attackPower = int.Parse(tokens[1]);
                    initialHealt -= attackPower;
                    string monsterName = tokens[0];
                    if (initialHealt > 0)
                    {

                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }

                }

            }
            if (initialHealt > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {initialHealt}");
            }



        }
    }
}

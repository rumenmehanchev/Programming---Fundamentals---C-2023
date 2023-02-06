using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.vowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string vowels = "AaEeIiOoUu";
            Console.WriteLine(GetCountVowels(message,vowels));

        }

        static string GetCountVowels(string message, string vowels)
        {
            int countVowels = 0;

            for (int i = 0; i < message.Length; i++)
            {
              char currentChar = message[i];
                if (vowels.Contains(currentChar))
                {
                    countVowels++;
                }
            }
            int result = int.Parse(countVowels +"");
            return result.ToString();
        }
    }
}

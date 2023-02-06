using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.palindromeIntegerss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
           // bool isPalindrome = true;

            while ((command = Console.ReadLine()) != "END")
            {
                double currentNum = double.Parse(command);

                string numAsString = currentNum.ToString();

                string[] arr = new string[numAsString.Length];
                int index = 0;

                for (int i = 0; i < numAsString.Length; i++)
                {
                    arr[index] = numAsString[i] + "";
                    index++;
                }
                if (GetPalindrome(arr))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }        
        }

        static bool GetPalindrome(string[] arr)
        {
             bool isPalindrome = true;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if ((arr[i] == arr[arr.Length - 1 - i]))
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                }

            }
            //if (isPalindrome || arr.Length == 1)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            return isPalindrome;
        }
    }
}

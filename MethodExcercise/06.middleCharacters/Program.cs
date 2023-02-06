using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.middleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddleCharacter(input));
        }
        // 0 1 2 3 4 5 6
        static string GetMiddleCharacter(string input)
        {
            int len = input.Length;
            string result = "";

            if (len % 2 == 1)
            {
                result = input[input.Length / 2] + ""; // S tova vzemame elementa po sredata v nqkakuv string ako daljinata e nechetna 
            }
            else
            {
                result = input[input.Length / 2 - 1] + "" + input[input.Length / 2] + ""; // vzemame dvata elementa po sredata zashtoto daljinata e chetna 
            }

            return result;
        }

    }
}

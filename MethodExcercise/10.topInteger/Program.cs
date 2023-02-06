using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.topInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            
            

            for (int i = 1; i <= endValue; i++)
            {
                int currentNum = i;
                string numberAsstring = i.ToString();

                if (GetCheckIsDivideByEight(endValue, numberAsstring) && GetChekFromOneDigitIsOdd(endValue,numberAsstring))
                {
                    list.Add(currentNum);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
        static bool GetCheckIsDivideByEight(int currentNum ,string numberAsstring)
        {        
            int sum = 0;
            bool isDivided = false;
            for (int j = 0; j < numberAsstring.Length; j++)
            {
                char nums = (char)numberAsstring[j];
                string nAsstring = nums.ToString();
                int number = int.Parse(nAsstring);
                sum += number;
            }
            if (sum % 8 == 0)
            {
                isDivided = true;
            }
            else
            {
                isDivided = false;
            }
            return isDivided;
        }
        static bool GetChekFromOneDigitIsOdd(int currentNum,string numberAsstring)
        {            
            bool isOdd = false;
            int countOdNum = 0;

            for (int k = 0; k < numberAsstring.Length; k++)
            {
                char nume = (char)numberAsstring[k];
                string nAsstring = nume.ToString();
                int number = int.Parse(nAsstring);

                if (number % 2 != 0)
                {
                    countOdNum++;
                }
            }
            if (countOdNum >= 1)
            {
                isOdd = true;
            }
            return isOdd;
        }      
    }
}

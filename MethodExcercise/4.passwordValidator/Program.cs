using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.passwordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            string password = Console.ReadLine();

            bool isPasFine = PasswordIsValid(password);
            if (isPasFine)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool GetResultFromCharBetweenSixOrTen(string pass)
        {
            int passLength = pass.Length;


            if ((passLength >= 6 && passLength <= 10))
            {
                return true;
            }
            return false;
        }

        static bool GetResultFromCheckConsistLetterOrDigit(string pass)
        {
            bool isValidPass = false;
            for (int i = 0; i < pass.Length; i++)
            {
                int currentLeter = pass[i];

                if ((currentLeter >= 48 && currentLeter <= 57) || (currentLeter >= 65 && currentLeter <= 90) || (currentLeter >= 97 && currentLeter <= 122))
                {
                    isValidPass = true;
                }
                else
                {
                    isValidPass = false;
                    break;

                }
            }
            return isValidPass;
        }

        static bool GetResultFromCheckHowmuchDigitContain(string pass)
        {
            int counterDigit = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                int currentDigit = pass[i];

                if (currentDigit >= 48 && currentDigit <= 57)
                {
                    counterDigit++;
                }
            }
            if (!(counterDigit >= 2))
            {
                return false;
            }
            return true;
        }

        static bool PasswordIsValid(string pas)
        {
            bool passWordIsvalid = true;

            if (!GetResultFromCharBetweenSixOrTen(pas))
            {
                passWordIsvalid = false;
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }
          
            if (!GetResultFromCheckConsistLetterOrDigit(pas))
            {               
                passWordIsvalid = false;
                Console.WriteLine($"Password must consist only of letters and digits");
            }
          
            if (!GetResultFromCheckHowmuchDigitContain(pas))
            {           
                passWordIsvalid = false;
                Console.WriteLine($"Password must have at least 2 digits");
            }
       
            return passWordIsvalid;
        }


    }
}


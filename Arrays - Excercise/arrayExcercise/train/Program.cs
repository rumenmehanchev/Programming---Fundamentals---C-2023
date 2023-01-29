using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalPeople = 0;

            int[] result = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                totalPeople+= people;
                result[i-1] = people;
               
            }
            Console.WriteLine(String.Join(" ", result));
            Console.WriteLine(totalPeople);

        }
    }
}

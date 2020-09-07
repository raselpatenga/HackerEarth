using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_of_Potion_making
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0, x = 1;

            if(input.Length == 3)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    sum = input[i] * x;
                }
                x++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}

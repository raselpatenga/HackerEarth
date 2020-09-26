using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int Z = 0, Y = 0;
            for (int s = 0; s < t; s++)
            {
                string[] ab = Console.ReadLine().Split(' ').ToArray();
                string a = ab[0];
                string b = ab[1];

                for (int i = 0; i < a.Length; i++)
                {
                    Z += (char)a[i] - 'a';
                }
                for (int j = 0; j < b.Length; j++)
                {
                    Y += (char)b[j] - 'a';
                }
                bool equal = true;

                if (Z != Y)
                {
                    equal = false;
                }
                if (equal)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadKey();
        }
    }
}

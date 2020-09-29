using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strArray = Console.ReadLine().Split(' ');
            int[] intArray = Array.ConvertAll(strArray, int.Parse);

            string isDivisible = intArray[n - 1] % 10 == 0 ? "Yes" : "No";
            Console.WriteLine(isDivisible);


            //int numOfTestCases = int.Parse(Console.ReadLine());
            //StringBuilder res = new StringBuilder();
            //while (numOfTestCases-- > 0)
            //{
            //    string[] rates = Console.ReadLine().Split(" ");
            //    int participants = int.Parse(Console.ReadLine()); ;
            //    int green = 0;
            //    int purple = 0;
            //    while (participants-- > 0)
            //    {
            //        string userStatusStr = Console.ReadLine();
            //        string[] userStatus = userStatusStr.Split(" ");
            //        green += int.Parse(userStatus[0]);
            //        purple += int.Parse(userStatus[1]);
            //    }
            //    res.Append(Math.Min((green * int.Parse(rates[0]) + purple * int.Parse(rates[1])), (green * int.Parse(rates[1]) + purple * int.Parse(rates[0]))) + "\n");
            //}
            //Console.WriteLine(res.ToString());


            //int t = Convert.ToInt32(Console.ReadLine());
            //int Z = 0,Y = 0;
            //for (int s = 0; s < t; s++)
            //{
            //    string[] ab = Console.ReadLine().Split(' ').ToArray();
            //    string a = ab[0];
            //    string b = ab[1];

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Z += (char)a[i] - 96;
            //    }
            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        Y += (char)b[i] - 96;
            //    }
            //    bool equal = true;

            //    if (Z != Y)
            //    {
            //        equal = false;
            //    }
            //    if (equal)
            //    {
            //        Console.WriteLine("YES");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //    }
            //}
            Console.ReadKey();

        }
    }
}

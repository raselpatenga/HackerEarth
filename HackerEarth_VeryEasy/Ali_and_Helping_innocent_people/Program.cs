using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_and_Helping_innocent_people
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();

            if ((inputs[0] + inputs[1]) % 2 == 0)
            {
                if (inputs[2] != 'A' && inputs[2] != 'E' && inputs[2] != 'I' && inputs[2] != 'O' && inputs[2] != 'U' && inputs[2] != 'Y')
                {
                    if ((inputs[3] + inputs[4]) % 2 == 0)
                    {
                        if ((inputs[4] + inputs[5]) % 2 == 0)
                        {
                            if ((inputs[7] + inputs[8]) % 2 == 0)
                            {
                                Console.WriteLine("valid");
                            }
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("invalid");
            }

            Console.ReadKey();
        }
    }
}

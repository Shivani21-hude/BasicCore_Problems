using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class Flipcoin
    {
        public static void PerHeadTail()
        {
            Console.WriteLine("Enter the number for flipcoin");
            int n = Convert.ToInt32(Console.ReadLine());
            int CountHead = 0;
            int CountTail = 0;
            for (int i = 0; i < n; i++)
            {

                Random random = new Random();
                int num = random.Next(2);
                if (num == 0)
                {
                    Console.WriteLine("tail");
                    CountHead++;
                }
                else
                {
                    Console.WriteLine("head");
                    CountTail++;
                }

            }
            Console.WriteLine("number of Heads :" + CountHead);
            Console.WriteLine("number of tails : " + CountTail);
            double Head = (CountHead / (double)n) * 100;
            double Tail = (CountTail / (double)n) * 100;
            Console.WriteLine("Percentage of head : " + Head);
            Console.WriteLine("percentage of tail : " + Tail);
        }
    }
}

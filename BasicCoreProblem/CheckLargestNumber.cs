using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class CheckLargestNumber
    {
        public static void CheckLargestNum()
        {
            Console.WriteLine("Enter 3 numbers to check which is the largest among them");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());

            if (a > b & a > c)
            {
                Console.WriteLine("{0} is largest number than {1} and {2}", a, b, c);
            }
            else if(b > a & b > c)
            {
                Console.WriteLine("{0} is largest number than {1} and {2}", b, a, c);
            }
            else if(c > a & c > b)
            {
                Console.WriteLine("{0} is largest number than {1} and {2}", c, a, b);
            }
        }
    }
}

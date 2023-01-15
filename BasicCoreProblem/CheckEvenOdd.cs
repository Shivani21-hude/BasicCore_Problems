using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class CheckEvenOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number to check even or odd");
            int n=Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("{0} is Even number", n);
            }
            else
            {
                Console.WriteLine("{0} is Odd number", n);
            }
        }
    }
}

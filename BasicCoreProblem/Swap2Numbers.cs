using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class Swap2Numbers
    {
        public static void SwappingNumbers()
        {
            Console.WriteLine("Enter two numbers to swap :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping : \n n1 = {0} , n2 = {1} ", n1, n2);
            n1 = n1 * n2;
            n2 = n1 / n2;
            n1 = n1 / n2;

            Console.WriteLine("After Swapping  : \n n1 = {0} , n2 = {1} ", n1, n2);
        }
    }
}

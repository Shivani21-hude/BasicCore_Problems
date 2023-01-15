using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class PowerofTwo
    {
        public static void Poweroftwo()
        {
            int num = 2;
            double pow = 0;
            Console.WriteLine("Enter a number for to get power of 2 ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Power of 2 : \n");
            for (int i = 1; i <= n; i++)
            {
                pow = Math.Pow(num, i);
                Console.WriteLine(pow);
            }

        }
    }
}

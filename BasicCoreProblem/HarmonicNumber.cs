using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class HarmonicNumber
    {
        public static void HarmonicNum()
        {
            Console.WriteLine("Enter a number  to print harmonic numbers");
            int n=Convert.ToInt32(Console.ReadLine());
            double harmonic = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ",i);
                harmonic = harmonic + 1 / (float)i;
                
            }
            Console.WriteLine("\n Sum of nth harmonic value : " + harmonic);
        }
    }
}

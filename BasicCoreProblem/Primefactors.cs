using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class Primefactors
    {
        public static void PrimefactorNumber()
        {
            Console.WriteLine("Enter a number to print prime factor up to n");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            Console.WriteLine("Prime numbers are :");

            for(int i = 2; i < n; i++)
            {
                bool isPrime = true;
                for(int j=2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i + " ");
                    fact = fact * i;
                }

            }
            Console.WriteLine("factorail of prime numbers :  " + fact+ "\n");
        }
    }
}

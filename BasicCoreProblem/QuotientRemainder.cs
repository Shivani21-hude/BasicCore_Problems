using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class QuotientRemainder
    {
        public static void Qutiont_Remainder()
        {
            Console.Write("Enter a number for devident : ");
            int devident=Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter a number for divisor : ");
            int divisor=Convert.ToInt32(Console.ReadLine());    

            int Quotient = devident / divisor;
            int Remainder = devident % divisor;

            Console.Write("\n Quotient = " + Quotient) ;
            Console.Write("\n Remainder = " + Remainder) ;
        }
    }
}

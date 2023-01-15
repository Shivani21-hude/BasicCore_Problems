using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class CheckAlphabet
    {
        public static void VowelConsonent()
        {
            Console.WriteLine("Enter a albhabet to check the alphabet vowel or consonent : ");
            char c = Convert.ToChar(Console.ReadLine());
           
            if(c == 'a'|| c  == 'e' || c  == 'i'|| c == 'o' || c == 'u' || 
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("{0} is vowel ",c);
            }
            else
            {
                Console.WriteLine("{0} is consonent ", c);
            }
        }
    }
}

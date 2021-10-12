using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class ConsoleApp29
    {
        public static void primeFactors(int n)
        {
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
                Console.Write(n);
        }
        
    }
}


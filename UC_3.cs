using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, a = 1;
            string N;
            Console.WriteLine("<<<<The power of 2 >>>>");
            Console.WriteLine("Enter one number :  ");
            N = Console.ReadLine();
            p = Convert.ToInt32(N);
            if (p < 31 && p >= 0)
            {
                while (p != 0)
                {
                    a = a * 2;
                    --p;
                }
                Console.WriteLine("The power of 2 is  " + a);
            }
            else
            {
                Console.WriteLine("Wrong input will over flow int");

            }
            Console.ReadLine();

        }


    }
}

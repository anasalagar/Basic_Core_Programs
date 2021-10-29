using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        //  C# Program to Find the Largest Among Three Numbers

        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("1) Enter first number ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2) Enter second number ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3) Enter third number ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The first number is greater " + a);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The third number is greater " + c);
                    Console.ReadLine();
                }
            }
            else if (b > c)
            {
                Console.WriteLine("The second number is greater " + b);
                Console.ReadLine();

            }
            else
                Console.WriteLine("The third number is greater " + c);
            Console.ReadLine();

        }
    }
}
        

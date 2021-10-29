using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a year ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0) 
            {
                Console.WriteLine("This  is leap year");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This  is not a leap year");
                Console.ReadLine();
            }

        }

    }
}
        

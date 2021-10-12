using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<CALCULATE THE HARMONIC NUMBER>>>>>>>>");
            int i;
            int a;
            

            Console.WriteLine("Enter a number : ");
            a = Convert.ToInt32(Console.ReadLine());
            double b = 0;
            for (i=1;i<=a;i++)
            {
                Console.Write("1/{0} + ",i);
                b += 1 / (float)i;
            }
            
            Console.WriteLine("\n The value  Harmonic Number is  {0} terms : {1} ", a,b);
            Console.ReadLine();
        }

        
    } 
}

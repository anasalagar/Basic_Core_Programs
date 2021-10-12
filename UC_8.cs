using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
      //  C# Program to Check Whether a Number is Even or Odd
       
        static void Main(string[] args)
        {
            int a=2;
            Console.Write("Enter one nmber ");
            a = Convert.ToInt32(Console.ReadLine());

            if(a%2==0)
            {
               Console.WriteLine("This  number is Even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This number is odd");
                Console.ReadLine();
            }


            }
        

    }
}
        

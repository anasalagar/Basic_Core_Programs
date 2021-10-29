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
            double a;
            double b;
            double c;
            double d;
            Console.WriteLine("<<<<<<Quotient and Remaindar program >>>>>>");
            
            Console.WriteLine("Enter one number : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a / b;
            d = a % b;

            Console.WriteLine("The value of quotient is : " + c);
            Console.ReadLine();

            Console.WriteLine("the value of remainder is: " + d);
            Console.ReadLine();
        }
    }

            
    }

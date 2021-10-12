using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random r = new Random();
            int flip = r.Next(0, 2);

            int head = 0;
            int tails = 0;
            int i = 0;
            double PerOfHead;
            double PerOfTails;


            Console.WriteLine("<<<<Welcome to coin flip game>>>>");

            Console.WriteLine("how many time you wanna flip the coin ?");
            int N = Convert.ToInt32(Console.ReadLine());


            while (i!= N)
            {
                flip =r.Next(2);
                if (flip==0)
                {
                    
                    Console.WriteLine("The toss number {0} outcome is : Heads", i + 1);
                    head++;
                }
                else
                {
                   
                    Console.WriteLine("The toss number {0} outcome is : Tails", i + 1);
                    tails++;
                }
                i++;
            }

            Console.WriteLine("numbers of tails are : " + tails);
            Console.ReadLine();
            Console.WriteLine("numbers of heads are : " + head);
            Console.ReadLine();

            PerOfHead = head / N * 100;
            PerOfTails = tails / N * 100;

            Console.WriteLine("Percentage of heads is " + PerOfHead);
            Console.ReadLine();
            Console.WriteLine("percentage of tails is " + PerOfTails);
            Console.ReadLine();


        }
    }
}

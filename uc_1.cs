using System;
namespace practice

{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int i = 0;
            double head = 0;
            double tails = 0;

            double PerOfHead;
            double PerOfTails;
            Console.WriteLine("<<<<Welcome to coin flip game>>>>\n");

            Console.Write("how many time you wanna flip the coin ? - ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (i != N)
            {
                int flip = r.Next(2);

                if (flip == 0)
                {
                    Console.WriteLine("The toss number {0} outcome is : Heads", i+1);
                    head++;
                }
                else
                {
                    Console.WriteLine("The toss number {0} outcome is : Tails", i+1);
                    tails++;
                }
                i++;
            }

            Console.WriteLine("\nNumbers of Tails are : " + tails);
            Console.WriteLine("Numbers of Heads are : " + head);

            PerOfHead = head / N * 100;
            PerOfTails = tails / N * 100;

            Console.WriteLine("\nPercentage of heads is " + PerOfHead);
            Console.WriteLine("percentage of tails is " + PerOfTails);
            Console.ReadLine();
        }
    }
}

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
            char wd;

            Console.WriteLine("Enter a word ");
            wd = Convert.ToChar(Console.ReadLine());


            // Condition for vowel checking
            if (wd == 'a' || wd == 'e' || wd == 'i' || wd == 'o' || wd == 'u' || wd == 'A' || wd == 'E' || wd == 'I' || wd == 'O' || wd == 'U')
            {

                Console.WriteLine( "This word is vowel ");

            }
            else if ((wd >= 'a' && wd <= 'z') || (wd >= 'A' && wd <= 'Z'))
            {
                Console.WriteLine("This word is consonant");
            }

            Console.ReadLine();
        }
    }

            
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModulus
{
    class Program
    {
        public Program()
        {
            PrintFunction();
        }

        static void Main()
        {
            new Program();
            Console.ReadKey();
        }

        // print from 1 to 100, if mod 3 print "Buzz" instead a number, if mod 5 print "Buzz", if mod 3 and mod 5 print "FizzBuzz"
        public void PrintFunction()
        {
            for (int i = 1; i <= 100; i++)
            {
                var isThree = i % 3 == 0;
                var isFive = i % 5 == 0;
                if (isThree && !isFive)
                {
                    Console.WriteLine("Fizz");
                }
                else if (!isThree && isFive)
                {
                    Console.WriteLine("Buzz");
                }
                else if (isThree && isFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

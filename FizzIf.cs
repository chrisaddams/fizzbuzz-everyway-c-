
using System;
namespace fizzbuzz
{
    public class fizzyIf
    {
        public static void If(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                Console.WriteLine(i);

            }
        }

    }
}
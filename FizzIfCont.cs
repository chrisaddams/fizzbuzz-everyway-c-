
using System;
namespace fizzbuzz
{
    public class fizzyIfCont
    {
        public static void IfCont(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(i);

            }
        }

    }
}
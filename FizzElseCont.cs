

using System;
namespace fizzbuzz
{
    public class fizzyElseCont
    {
        public static void ElseCont(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    continue;

                }
            }
        }
    }
}
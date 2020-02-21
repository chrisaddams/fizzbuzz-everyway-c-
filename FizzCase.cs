using System;
namespace fizzbuzz
{
    public class fizzyCase
    {
        public static void Case(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                switch (true)
                {
                    case var FizzBuzz when (i % 15 == 0):
                        Console.WriteLine("fizzbuzz");
                        break;
                    case var Fizz when (i % 3 == 0):
                        Console.WriteLine("fizz");
                        break;
                    case var Buzz when (i % 5 == 0):
                        Console.WriteLine("buzz");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }
    }
}
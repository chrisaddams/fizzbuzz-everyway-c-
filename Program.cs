
using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!, welcome to FizzBuzz. Press 1 for Case, press 2 for If/Else");
            int selector = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How high would you like to count?");
            int count = Convert.ToInt32(Console.ReadLine());
            if (selector == 1)
            {
                fizzyCase.Case(count);
            }
            else
            {
                fizzyElse.Else(count);
            };
        }
    }

}

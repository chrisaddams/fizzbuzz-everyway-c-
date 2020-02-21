using System.Diagnostics;
using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to FizzBuzz. Press 1 for Case, 2 for If/Else/Cont, 3 for If/Else, 4 for If Only, 5 for If/Cont");
            int selector = Convert.ToInt32(Console.ReadLine());
            int count = 10000;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            switch (selector)
            {
                case 1:
                    fizzyCase.Case(count);
                    break;
                case 2:
                    fizzyElseCont.ElseCont(count);
                    break;
                case 3:
                    fizzyElse.Else(count);
                    break;
                case 4:
                    fizzyIf.If(count);
                    break;
                case 5:
                    fizzyIfCont.IfCont(count);
                    break;
                default:
                    break;
            }
            timer.Stop();
            Console.WriteLine("Elapsed:{0}milliseconds", timer.Elapsed.TotalMilliseconds);
            using (System.IO.StreamWriter
            file = new System.IO.StreamWriter(@"./" + selector, true))
            {
                file.WriteLine(timer.Elapsed.TotalMilliseconds.ToString());
            }
        }
    }

}

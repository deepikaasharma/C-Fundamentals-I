using System;

namespace _02.Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // No. 1
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            // No 2.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // No. 3
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 ==0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

            // Optional No. 1
            int num = 1;
            while (num <= 255)
            {
                Console.WriteLine(num);
                num++;
            }

            // Optional No. 2
            int num2 = 0;
            while (num2 <= 100)
            {
                num2++;
                if (num2 % 3 == 0 && num2 % 5 == 0)
                {
                    continue;
                }
                else if (num2 % 3 == 0 || num2 % 5 == 0)
                {
                    Console.WriteLine(num2);
                }
            }

            // Optional No. 3
            int num3 = 0;
            while (num3 <= 100)
            {
                num3++;
                if (num3 % 3 ==0 && num3 % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num3 % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num3 % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}

using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints Prime Numbers from 1 to 10,000
            bool flag;

            Console.WriteLine("Prime Numbers (between 1-10000): ");
            for (int i = 2; i <= 10000; i++)
            {
                flag = false;               
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }

                }
                if (!flag)
                    Console.WriteLine($"{i}");
            }
        }
    }
}

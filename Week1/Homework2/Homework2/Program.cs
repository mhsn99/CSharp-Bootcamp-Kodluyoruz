using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints number that users enter is prime or not
           
            try
            {
                bool flag = false;
                Console.Write("Enter the number: ");
                uint num = Convert.ToUInt32(Console.ReadLine());

                if (num == 0 || num == 1)
                    Console.WriteLine($"{num} is not prime");
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        flag = false;
                        if (num % i == 0)
                        {
                            Console.WriteLine($"{num} is not prime");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                        Console.WriteLine($"{num} is prime");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the value in integer format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter positive number.");
            }
        }
    }
}

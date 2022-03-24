using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Letter grade calculator

            try
            {
                Console.Write("Please enter your Midterm 1 score: ");
                byte mid1 = Convert.ToByte(Console.ReadLine());

                Console.Write("Please enter your Midterm 2 score: ");
                byte mid2 = Convert.ToByte(Console.ReadLine());

                Console.Write("Please enter your Final score: ");
                byte final = Convert.ToByte(Console.ReadLine());

                // Midterm 1 and Midterm 2 -> %30, Final -> %40

                double overallScore = (mid1 + mid2) * 0.3 + final * 0.4;

                if (overallScore < 45)
                    Console.WriteLine($"Overall: {overallScore} | Result: It does not matter, you fail.");
                else if (overallScore < 50)
                    Console.WriteLine($"Overall: {overallScore} | Result: 'DC' - Provisionally Successful");
                else if (overallScore < 60)
                    Console.WriteLine($"Overall: {overallScore} | Result: 'CC' - Satisfactory");
                else if (overallScore < 70)
                    Console.WriteLine($"Overall: {overallScore} | Result: 'CB' - Average");
                else if (overallScore < 80)
                    Console.WriteLine($"Overall: {overallScore} | Result: 'BB' - Good");
                else if (overallScore < 90)
                    Console.WriteLine($"Overall: {overallScore} | Result: 'BA' - Very Good");
                else
                    Console.WriteLine($"Overall: {overallScore} | Result: 'AA' - Excellent");

            }
            catch (FormatException)
            {
                Console.WriteLine("Midterm/Final score must be positive integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Midterm/Final score cannot be negative.");
            }

        }
    }
}

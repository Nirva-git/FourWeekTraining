using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Day4Exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate a large collection of random numbers
            List<int> data = GenerateRandomNumbers(10000000);

            // Measure the execution time of the original query
            Stopwatch sw = Stopwatch.StartNew();

            // Original implementation
            var originalQuery = data.Where(x => x > 100).OrderByDescending(x => x).Take(10);

            sw.Stop();
            Console.WriteLine("Original Query: {0} ms", sw.ElapsedMilliseconds);

            // Measure the execution time of the optimized query
            sw.Restart();

            // Optimized implementation
            var optimizedQuery = data.AsParallel() // Enables parallel execution for improved performance
                                   .Where(x => x > 100)
                                   .OrderByDescending(x => x)
                                   .Take(10);

            sw.Stop();
            Console.WriteLine("Optimized Query: {0} ms", sw.ElapsedMilliseconds);
        }

        static List<int> GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next();
                numbers.Add(randomNumber);
            }

            return numbers;
        }
    }
}

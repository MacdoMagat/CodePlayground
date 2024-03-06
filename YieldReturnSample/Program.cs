using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace YieldReturnSample
{
    internal class Program
    {
        //yield return is a C# keyword used in iterator methods to lazily generate and return individual elements of a sequence.
        //Instead of generating and storing all elements upfront in memory, yield return allows elements to be produced one at a time as they are needed.
        //This approach can save memory and improve performance, especially when dealing with large or infinite sequences.
        //Essentially, yield return enables the creation of custom iterators in C# by suspending and resuming the execution of a method to produce each element of the sequence.
        static void Main(string[] args)
        {
            // Measure memory usage without yield return
            var stopwatch = Stopwatch.StartNew();
            var numbersList = GenerateNumbersList(); // Generate numbers eagerly and store them in a list
            stopwatch.Stop();
            Console.WriteLine("Memory used with list: " + GC.GetTotalMemory(true)); // Output memory usage
            Console.WriteLine("Time taken with list: " + stopwatch.ElapsedMilliseconds + " ms"); // Output time taken

            // Measure memory usage with yield return
            stopwatch.Restart();
            var numbersEnumerable = GenerateNumbersYield(); // Generate numbers lazily using yield return
            stopwatch.Stop();
            Console.WriteLine("Memory used with yield return: " + GC.GetTotalMemory(true)); // Output memory usage
            Console.WriteLine("Time taken with yield return: " + stopwatch.ElapsedMilliseconds + " ms"); // Output time taken

            Console.ReadKey();
        }

        // Method to generate numbers eagerly and store them in a list
        public static List<int> GenerateNumbersList()
        {
            var numbers = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        // Method to generate numbers lazily using yield return
        public static IEnumerable<int> GenerateNumbersYield()
        {
            for (int i = 0; i < 1000000; i++)
            {
                yield return i;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    internal class Program
    {
        //There is another version of Main method here because await TaskWhenAll() needs to be inside a method that is marked as async Task
        //static async Task Main(string[] args)
        //{
        //    await TaskWhenAll();
        //    ParallelForEach();
        //    ParallelInvokeUsingAction();
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            TaskWhenAll().GetAwaiter().GetResult();
            ParallelForEach();
            ParallelInvokeUsingAction();
            Console.ReadLine();
        }

        private static async Task TaskWhenAll()
        {
            // Define multiple funcs to be invoked in parallel
            Task<int> task1 = Task.Run(() =>
            {
                Console.WriteLine("Func 1 started");
                System.Threading.Thread.Sleep(1000); // Simulate some work
                Console.WriteLine("Func 1 completed");
                return 1;
            });

            Task<string> task2 = Task.Run(() =>
            {
                Console.WriteLine("Func 2 started");
                System.Threading.Thread.Sleep(2000); // Simulate some work
                Console.WriteLine("Func 2 completed");
                return "two";
            });

            Task<bool> task3 = Task.Run(() =>
            {
                Console.WriteLine("Func 3 started");
                System.Threading.Thread.Sleep(1500); // Simulate some work
                Console.WriteLine("Func 3 completed");
                return true;
            });

            // Wait for all tasks to complete
            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("All funcs completed.");

            // Retrieve results
            int result1 = await task1;
            string result2 = await task2;
            bool result3 = await task3;

            // Print results
            Console.WriteLine($"Result 1: {result1}");
            Console.WriteLine($"Result 2: {result2}");
            Console.WriteLine($"Result 3: {result3}");
        }

        private static void ParallelInvokeUsingAction()
        {
            // Define multiple actions to be invoked in parallel
            Action action1 = () =>
            {
                Console.WriteLine("Action 1 started");
                System.Threading.Thread.Sleep(1000); // Simulate some work
                Console.WriteLine("Action 1 completed");
            };

            Action action2 = () =>
            {
                Console.WriteLine("Action 2 started");
                System.Threading.Thread.Sleep(2000); // Simulate some work
                Console.WriteLine("Action 2 completed");
            };

            Action action3 = () =>
            {
                Console.WriteLine("Action 3 started");
                System.Threading.Thread.Sleep(1500); // Simulate some work
                Console.WriteLine("Action 3 completed");
            };

            // Invoke all actions in parallel
            Parallel.Invoke(action1, action2, action3);

            Console.WriteLine("All actions completed.");
        }

        private static void ParallelForEach()
        {
            // Define an array of numbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Use Parallel.ForEach to compute squares of numbers in parallel
            Parallel.ForEach(numbers, number =>
            {
                Console.WriteLine($"Processing {number}");
                Thread.Sleep(2000);
                int square = number * number;
                Console.WriteLine($"Square of {number} is {square}");
            });

            Console.WriteLine("Parallel computation complete.");
        }
    }
}

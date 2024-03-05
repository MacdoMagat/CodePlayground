using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = "originalString";

            Action<string> myAction1 = newString => originalString = newString;
            Action<string> myAction2 = delegate (string newString) { originalString = newString; };
            Action<string> myAction3 = (newString) => { originalString = newString; };

            myAction1("My Action 1");
            Console.WriteLine(originalString);

            myAction3("My Action 2");
            Console.WriteLine(originalString);

            myAction3("My Action 3");
            Console.WriteLine(originalString);

            Func<int, int, string>myFunc1 = (num1, num2) => { return (num1 + num2).ToString(); };
            Func<int, int, string> myFunc2 = delegate (int num1, int num2) { return (num1 + num2).ToString(); };
            Func<int, string> myFunc3 = myInt => myInt == 0 ? "Is zero" : "Is not zero";

            Console.WriteLine();
            Console.WriteLine(myFunc1(1, 2));
            Console.WriteLine(myFunc2(3, 4));
            Console.WriteLine(myFunc3(0));
            Console.WriteLine(myFunc3(1));

            Func<int, string> myFunc4 = Func4;
            Console.WriteLine(myFunc4(3));

            Action<string> myAction4 = Action4A;
            myAction4 += Action4B;
            myAction4("Marc");

            Console.ReadLine();
        }

        private static string Func4(int num)
        {
            int squared = num ^ 2;
            return "2 squared is " + squared;
        }

        private static void Action4A(string name) {
            Console.WriteLine($"Hi! My name is {name}");
        }

        private static void Action4B(string name)
        {
            Console.WriteLine($"Konnichiwa! Watashi wa namae {name} des");
        }
    }
}

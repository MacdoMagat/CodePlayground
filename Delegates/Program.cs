using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string MyDelegateTest(string inputString);
    internal class Program
    {
        static MyDelegateTest testDelegate;
        static void Main(string[] args)
        {
            testDelegate += MyMethod;
            testDelegate += MyMethod2;

            string returnString = testDelegate("Test");

            Console.WriteLine($"Return string is: \"{returnString}\"");
            Console.ReadLine();
        }

        public static string MyMethod(string myMessage)
        {
            Console.WriteLine(myMessage + "A");
            return myMessage;
        }

        public static string MyMethod2(string myMessage)
        {
            Console.WriteLine(myMessage + "B");
            return "Returned from MyMethod2: " + myMessage;
        }
    }
}

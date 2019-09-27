using System;

namespace Session1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicit Typing
            // Declaration
            int number;
            char[] letters2 = new char[5];

            // Implicit Typing
            // Declaration + Initialization
            var number2 = 2;
            var letters = new char[5];

            // Initial Values in Array are null
            var words = new string[10];
            var blank = string.Empty;
            Console.WriteLine(words[0]);
            Console.WriteLine(words[0] == null);
            Console.WriteLine("Hello World!");

            // Implicit Declaration and Initialization
            // Array's first index is big fat ZERO 
            // Last one = Size - 1
            var namedWords = new [] { "zero", "one" };
            Console.WriteLine(namedWords[1]);
        }
    }
}

using System;

namespace Session2
{
    class Program
    {
        /*
         * 
         * Start a cycle.
         * Generate a random number between 1 and 100
         * Save the first time ever-generated number into a global variable named x         
         * Call method DisplaySequence passing the <number> as parameter
            
          Inside method:  
            Print a character a <number> amount of times
            If <number> is even, print '*'
            If <number> is odd, print '+'
            Print until the number received is equals to exactly (2x + 1)
         * 
         */
        private static int firstNumber;
        static void Main(string[] args)
        {
            var randomNumber = 10; // TODO: Change it to random           
            // Put this call inside a cycle
            DisplaySequence(randomNumber);
        }
        private static void DisplaySequence(int number)
        {

        }
    }
}
}

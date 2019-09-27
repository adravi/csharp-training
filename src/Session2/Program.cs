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
            var randomGenerator = new Random();
            int randomNumber;

            do
            {
                randomNumber = randomGenerator.Next(1, 10);

                if (firstNumber == 0)
                {
                    firstNumber = randomNumber;
                }

                DisplaySequence(randomNumber);

            } while (randomNumber != (8));

        }



        private static void DisplaySequence(int number)
        {
            
            if (number % 2 == 0)
            {
                // even
                Console.Write("\n" + number + " : ");
                    
                for (int i = 0; i < number; i++)
                {                        
                    Console.Write("*");
                }
                    
            }
            else
            {
                // odd
                Console.Write("\n" + number + " : ");

                for (int i = 0; i < number; i++)
                {
                    Console.Write("+");
                }
                    
            }
            
            
        }
    }
}
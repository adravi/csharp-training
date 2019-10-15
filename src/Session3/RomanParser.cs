using System;

namespace Session3
{
    public class RomanParser
    {
        public int RomanToInt(string romanNumber)
        {
           
            var firstSymbol = romanNumber[0]; 
                        
            var sum = 0; // TODO: Initialize sum with the right value!

            // The first previous is first symbol ever
            var prev = firstSymbol; // TODO: Initialize the value of prev!
            sum += EvalSymbol('x', firstSymbol);
            Console.WriteLine(sum);
            // Start iterate the roman number, from the second symbol
            // TODO: Start the value of i on the appropriate value!
            for (int i = 1; i < romanNumber.Length; i++)
            {
                char symbol = romanNumber[i];
                sum += EvalSymbol(prev, symbol); // TODO: Make the call with the appropriate values!   
                prev = symbol;
            }

            return sum;
            
        }

        private int EvalSymbol(char prev, char curr)
        {
            var val = 0;

            // TODO: Build the switch case statement
            switch (curr)
            {
                case 'I':
                    val  = 1;
                    break;
                // Action
                case 'V':
                    if (prev.Equals('I'))
                    {
                        // TODO: Update sum accordingly
                         val = 4;
                    }
                    else
                    {
                        val = 5;
                    }
                    break;
                case 'X':
                    if (prev.Equals('I'))
                    {
                        // TODO: Update sum accordingly
                        val = 9;
                    }
                    else
                    {
                        val = 10;
                    }
                    break;
                case 'L':
                    if (prev.Equals('I'))
                    {
                        // TODO: Update sum accordingly
                        val = 40;
                    }
                    else
                    {
                        val = 50;
                    }
                    break;
                case 'C':
                    if (prev.Equals('I'))
                    {
                        // TODO: Update sum accordingly
                        val = 90;
                    }
                    else
                    {
                        val = 100;
                    }
                    break;
                case 'D':
                    if (prev.Equals('I'))
                    {
                        // TODO: Update sum accordingly
                        val = 400;
                    }
                    else
                    {
                        val = 500;
                    }
                    break;
                case 'M':
                    if (prev.Equals('I'))
                    {
                        // TODO: Update sum accordingly
                        val = 900;
                    }
                    else
                    {
                        val = 1000;
                    }
                    break;

                //    // ... // TODO: Finish the cases
                default:
                    break;
            }

            return val;
        }
    }
}

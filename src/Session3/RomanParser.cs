using System;

namespace Session3
{
    public class RomanParser
    {
        public int RomanToInt(string romanNumber)
        {
            // Get the value of first symbol
            int firstSymbol; // TODO: Make the appropriate calculation!

            // First value
            int sum = -1; // TODO: Initialize sum with the right value!

            // The first previous is first symbol ever
            int prev; // TODO: Initialize the value of prev!

            // Start iterate the roman number, from the second symbol
            // TODO: Start the value of i on the appropriate value!
            for (int i = -1; i < romanNumber.Length; i++)
            {
                char symbol = romanNumber[i];
                sum += EvalSymbol('z', 'z'); // TODO: Make the call with the appropriate values!
            }

            return sum;
        }

        private int EvalSymbol(char prev, char curr)
        {
            var val = 0;

            // TODO: Build the switch case statement
            //switch (curr)
            //{
            //    case 'I':
            //        // Action
            //        if (prev.Equals('z'))
            //        {
                        // TODO: Update sum accordingly
                        // sum += -1;
            //        }
            //        else
            //        {

            //        }
            //        break;
            //    // ... // TODO: Finish the cases
            //    default:
            //        break;
            //}

            return val;
        }
    }
}

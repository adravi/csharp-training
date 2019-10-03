using System;

namespace Session3
{
    public class RomanParser
    {
        public int RomanToInt(string romanNumber)
        {
            var sum = 0;
            var firstSymbol = romanNumber[0];

            // Get the value of first symbol
            sum += EvalSymbol('z', firstSymbol);

            // The first previous is first symbol ever
            var prev = firstSymbol;

            // Start iterate the roman number, from the second symbol
            for (int i = 1; i < romanNumber.Length; i++)
            {
                var symbol = romanNumber[i];
                sum += EvalSymbol(prev, symbol);
            }

            return sum;
        }

        private int EvalSymbol(char prev, char curr)
        {
            var val = 0;

            switch (curr)
            {
                case 'I':
                    val = 1;
                    break;
                case 'V':
                    if (prev.Equals('I'))
                    {
                        // IV
                        val = 3; // 4-1
                    }
                    else
                    {
                        val = 5;
                    }
                    break;
                case 'X':
                    if (val.Equals('I'))
                    {
                        // IX
                        val = 8; // 9-1
                    }
                    else
                    {
                        val = 10;
                    }
                    break;
                case 'L':
                    if (prev.Equals('X'))
                    {
                        // XL
                        val = 30; // 40-10
                    }
                    else
                    {
                        val = 50;
                    }
                    break;
                case 'C':
                    if (prev.Equals('X'))
                    {
                        // XC
                        val = 80; // 90-10
                    }
                    else
                    {
                        val = 100;
                    }
                    break;
                case 'D':
                    if (prev.Equals('C'))
                    {
                        // CD
                        val = 300; // 400-100
                    }
                    else
                    {
                        val = 500;
                    }

                    break;
                case 'M':
                    if (prev.Equals('C'))
                    {
                        // CM
                        val = 800; // 900-100
                    }
                    else
                    {
                        val = 1000;
                    }
                    break;
                default:
                    // Do nothing
                    break;
            }

            return val;
        }
    }
}

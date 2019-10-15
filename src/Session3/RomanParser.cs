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
            for (var i = 1; i < romanNumber.Length; i++)
            {
                var symbol = romanNumber[i];
                sum += EvalSymbol(prev, symbol);
                prev = symbol;
            }

            return sum;
        }

        private static int EvalSymbol(char prev, char current)
        {
            var val = 0;

            switch (current)
            {
                case 'I':
                    val = 1;
                    break;
                case 'V':
                    val = prev.Equals('I') ? 3 : 5;
                    break;
                case 'X':
                    val = val.Equals('I') ? 8 : 10;
                    break;
                case 'L':
                    val = prev.Equals('X') ? 30 : 50;
                    break;
                case 'C':
                    val = prev.Equals('X') ? 80 : 100;
                    break;
                case 'D':
                    val = prev.Equals('C') ? 300 : 500;
                    break;
                case 'M':
                    val = prev.Equals('C') ? 800 : 1000;
                    break;
            }

            return val;
        }
    }
}

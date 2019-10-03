namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new RomanParser();

            var romanChain = "II";
            parser.RomanToInt(romanChain);
        }
    }
}

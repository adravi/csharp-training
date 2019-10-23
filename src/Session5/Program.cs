using System;

namespace Session5
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();
            square.Length = 20;
            square.Color = "Blue";
            Console.WriteLine("Length: " + square.Length);
            Console.WriteLine("Area: " + square.Area);
            Console.WriteLine("Volume: " + square.Volume);
            Console.WriteLine("Color: " + square.Color);
        }
    }
}

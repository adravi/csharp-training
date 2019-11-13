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

            var triangle = new Triangle();
            triangle.Length = 20;
            triangle.Height = 5;
            triangle.Color = "Red";
            
            Console.WriteLine("Area: " + triangle.Area);
            Console.WriteLine("Volume: " + triangle.Volume);
            Console.WriteLine("Color: " + triangle.Color);

            var circle = new Clircle();
            circle.Radius = 5;
            triangle.Color = "Red";

            Console.WriteLine("Area: " + circle.Area);
            Console.WriteLine("Volume: " + circle.Volume);
            Console.WriteLine("Color: " + circle.Color);

        }
    }
}

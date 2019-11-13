using System;
using System.Collections.Generic;
using System.Text;

namespace Session5
{
    class Triangle
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area
        {
            get
            {
                return 1/2 * Height * Length;
            }
        }
        public int Volume
        {
            get
            {
                // Assume a pyramid
                return 1/6 * Height * Length * Width;
            }
        }
         public string Color { get; set; }
    }
}

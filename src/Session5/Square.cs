using System.Runtime.InteropServices;

namespace Session5
{
    public class Square
    {
        public int Length { get; set; }

        public int Area
        {
            get
            {
                return Length * Length;
            }
        }

        public int Volume
        {
            get
            {
                // Assume a cube
                return Area * Length;
            }
        }
        public string Color { get; set; }
    }
}

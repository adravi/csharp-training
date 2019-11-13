﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Session5
{
    class Clircle
    {
        public int Radius { get; set; }
              

        public int Area
        {
            get
            {
                return 22/7 * Radius * Radius;
            }
        }
        public int Volume
        {
            get
            {
                // Assume a pyramid
                return 4/3 * 22/7 *Radius * Radius * Radius;
            }
        }
        public string Color { get; set; }
    }
}

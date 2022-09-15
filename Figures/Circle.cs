﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Circle:Figure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI*Radius*Radius;
        }

        public override double Perimetr()
        {
            return 2*Math.PI*Radius;
        }
    }
}

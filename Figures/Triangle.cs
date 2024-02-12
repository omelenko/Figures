using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        public Triangle(double a1, double b1, double c1) { a = a1; b = b1; c = c1; }
        public double a, b, c;
        public override double ShowArea()
        {
            return (a * b)/2;
        }
    }
}

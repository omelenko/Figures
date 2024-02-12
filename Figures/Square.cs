using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Figure
    {
        public Square(double a1) { a = a1; }
        public double a;
        public override double ShowArea()
        {
            return a * a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class Quadrant : AbstractFigure
    {
        public Quadrant(double radius, double a, double b) : base(radius, a, b)
        {
            radius = 0;
            a = 2;
            b = 2;
        }
        public override double CalculateSquare(double radius, double a, double b)
        {
            return a * b;
        }
    }
}

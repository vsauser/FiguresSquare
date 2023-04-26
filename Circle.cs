using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class Circle : AbstractFigure
    {
        public Circle(double radius, double a, double b) : base(radius, a, b)
        {
            radius = 2;
            a = 0;
            b = 0;
        }
        public override double CalculateSquare(double radius, double a, double b)
        {
            return Math.PI * radius * radius;
        }
    }
}

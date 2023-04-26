using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public abstract class AbstractFigure : IFigure
    {
        protected double Radius { get; }
        protected double A { get; }
        protected double B { get; }

        public abstract double CalculateSquare(double radius, double a, double b);

        protected AbstractFigure(double radius, double a, double b)
        {
            Radius = radius;
            A = a;
            B = b;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class Rectangle : AbstractFigure
    {
        private readonly double _a;
        private readonly double _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }
        public override double CalculateSquare()
        {
            return _a * _b;
        }
    }
}

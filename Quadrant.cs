using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class Quadrant : AbstractFigure
    {
        private readonly double _a;
        private readonly double _b;

        public Quadrant(double a, double b)
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

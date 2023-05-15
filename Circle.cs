using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare
{
    public class Circle : AbstractFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public override double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}

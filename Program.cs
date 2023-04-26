using System;
using System.Collections.Generic;

namespace FiguresSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            List<AbstractFigure> figure = new List<AbstractFigure>() { new Circle(2, 0, 0), new Quadrant(0, 2, 2), new Rectangle(0, 1, 2) };

            Console.WriteLine("Hello World!");

            /*
            Circle circle = new Circle();
            result = circle.CalculateSqure(4, 0, 0);
            Console.WriteLine(result);

            Quadrant quadrant = new Quadrant();
            result = quadrant.CalculateSqure(0, 2, 2);
            Console.WriteLine(result);

            Rectangle rectangle = new Rectangle();
            result = rectangle.CalculateSqure(0, 1, 2);
            Console.WriteLine(result);*/

            foreach (AbstractFigure element in figure)
            {
                Console.WriteLine(element);
            }
/*
            for (int i = 0; i < figure.Count; i++)
            {
                try
                {
                    result = figure[i].CalculateSquare(2, 0, 0);
                    Console.WriteLine(result);

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Bad variant");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    break;
                }

            }*/
        }
    }
}

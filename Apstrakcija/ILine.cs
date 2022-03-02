using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija
{
    public struct Point
    {
        public readonly double X, Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    public interface ILine
    {
        double K { get; }
        double L { get; }
        Point? Intersection(ILine other);
    }
}

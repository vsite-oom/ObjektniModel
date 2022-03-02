using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstrakcija
{
    public struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;

        }
        public readonly x;
        public readonly y;
    }

   public interface ILine
    {
        Point? Intersection(ILine other);
    }
}

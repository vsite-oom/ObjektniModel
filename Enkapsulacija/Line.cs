using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apstrakcija;
namespace Enkapsulacija
{
     class Line : ILine
    {
        public Line(double k, double l)
        {
            this.k = k;
            this.l = l;
        }
        public Point? Intersection(ILine other)
        {

            if (k == other.K)
                return null;
            else
            {
                double x = (other.L - l) / (k - other.K);
                double y = k * x + l;
                return new Point(x, y);
            }
        }
        private double k, l;

        public double K =>k;

        public double L => l;
    }
}

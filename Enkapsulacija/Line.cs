﻿using Apstrakcija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    internal class Line : ILine
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

                double x = (other.l - l) / (k - other.K);
                double y = k * x + l;
                return new Point(x, y);
            }
        }

        private double k;
        private double l;

        public double K => throw new NotImplementedException();

        double ILine.l => throw new NotImplementedException();
    }
}

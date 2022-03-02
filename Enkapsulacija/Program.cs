using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l1 = new Line(1, 0);
            Line l2 = new Line(0, 1);

            var intersection =l1.Intersection(l2);
            if (intersection.HasValue)
                Console.WriteLine(intersection.Value);
            else
                Console.WriteLine("Lines are parallel");
        }
    }
}

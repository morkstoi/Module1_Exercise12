using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleClass
{
    static class CircleDefi
    {
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetArea(double r)
        {
            return  Math.PI * r*r;
        }
        static public bool IsWithinBounadries(double x1,double y1, double x0, double y0, double r)
        {
            double distance = Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));
            return distance <= r;
        }

    }
}

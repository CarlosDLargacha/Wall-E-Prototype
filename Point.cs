using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public class Point : Geos
    {
        public (double X, double Y) Coordinates { get; set; }

        public Point(int relevance, string name, (double X, double Y) coordinates)
            : base(relevance,name)
        {
            Coordinates = coordinates;
        }

        public double Determinar(Point otroPoint)
        {
             double dx = Coordinates.X - otroPoint.Coordinates.X;
            double dy = Coordinates.Y - otroPoint.Coordinates.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }


    }
}

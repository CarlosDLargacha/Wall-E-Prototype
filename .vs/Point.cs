using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public class Point : Geos
    {
        public (double X, double Y) Coordinates { get; set; }

        public Point(int relevance, (double X, double Y) coordinates)
            : base(relevance)
        {
            Coordinates = coordinates;
        }

        // Métodos y propiedades adicionales para implementar en las clases derivadas
    }
}
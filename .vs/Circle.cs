using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public class Circle : Geos
    {
        public int Radius { get; set; }
        public (double X, double Y) Center { get; set; }

        public Circle(int relevance, int radius, (double X, double Y) center)
            : base(relevance)
        {
            Radius = radius;
            Center = center;
        }

        // Métodos y propiedades adicionales para implementar en las clases derivadas
    }
}
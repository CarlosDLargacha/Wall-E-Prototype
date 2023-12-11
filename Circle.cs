using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public class Circle : Geos, IDistancia
    {
        public int Radius { get; set; }
        public (double X, double Y) Center { get; set; }

        public Circle(int relevance,string name, int radius, (double X, double Y) center)
            : base(relevance, name)
        {
            
            Radius = radius;
            Center = center;
        }

        // Implementación de la interfaz IDistancia
        public double CalcularDistancia((double X, double Y) punto)
        {
            return Math.Sqrt(Math.Pow(Center.X - punto.X, 2) + Math.Pow(Center.Y - punto.Y, 2));
        }

        public double CalcularDistancia(Circle circunferencia)
        {
            return Math.Sqrt(Math.Pow(Center.X - circunferencia.Center.X, 2) + Math.Pow(Center.Y - circunferencia.Center.Y, 2));
        }

        // Métodos y propiedades adicionales para implementar en las clases derivadas
    }
}

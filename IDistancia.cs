using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
   public interface IDistancia
{
    double CalcularDistancia((double X, double Y) punto);
    double CalcularDistancia(Circle circunferencia);
}
}
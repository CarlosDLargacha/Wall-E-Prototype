using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public abstract class Geos : Token
    {
        protected Geos(int relevance, string name) : base(relevance, name)
        {
        }

        // Métodos y propiedades adicionales para implementar en las clases derivadas
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public abstract class Methods : Token
    {
        protected List<string> _methodsList;

        protected Methods(int relevance, List<string> methodsList) : base(relevance)
        {
            _methodsList = methodsList;
        }

        // Métodos y propiedades adicionales para implementar en las clases derivadas
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public abstract class Methods : Token
    {
        protected List<Token> _methodsList;

        protected Methods(int relevance,string name, List<Token> methodsList) : base(relevance, name)
        {
            _methodsList = methodsList;
        }

        // Métodos y propiedades adicionales para implementar en las clases derivadas
    }
}
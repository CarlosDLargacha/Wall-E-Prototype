using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public abstract class Token
    {
        public int Relevance { get; set; }
        public string Name { get; set; }

        protected Token(int relevance, string name)
        {
            Relevance = relevance;
            Name = name;
        }

        // Métodos y propiedades adicionales para implementar en las clases derivadas
    }
}
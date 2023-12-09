using System;
using System.Collections.Generic;

namespace WallE
{
    public class Parser
    {
        private List<List<string>> _tokens;

        public Parser(List<List<string>> tokens)
        {
            _tokens = tokens;
        }

        public Expresion Parse()
        {
            if (_tokens.Count == 0)
            {
                throw new ArgumentException("No se proporcionaron tokens para analizar");
            }

            return ParseExpression(_tokens[0]);
        }

        private Expresion ParseExpression(List<string> tokens)
        {
           

            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WallE
{
    public class Parser
    {
        private List<List<Token>> _tokens;

        public Parser(List<List<Token>> tokens)
        {
            _tokens = tokens;
        }

        public string Parse()
        {
            if (this._tokens.Count == 0)
            {
                throw new ArgumentException("No se proporcionaron tokens para analizar");
            }

            return ParseExpression(_tokens[0]);
        }

        private string ParseExpression(List<Token> tokens)
        {
            string result = string.Empty;
            for (int i = 0; i < tokens.Count; i++)
            {
                Token currentToken = tokens[i];
                switch (currentToken.Name)
                {
                    case "Let":

                    default:
                        throw new ArgumentException("Token desconocido");
                }
            }
            return result;
        }
    }
}
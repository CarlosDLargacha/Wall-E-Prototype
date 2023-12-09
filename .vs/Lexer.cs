using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE 
{
    public class Lexer
    {
        public List<List<string>> Tokenize(string input)
        {
            var tokens = Regex.Split(input, "([,;.]|[+\-*/%^!~]|[<>=]=|!=|==|&&|\\|\\||\\w+)");
            return tokens.Where(t => !string.IsNullOrWhiteSpace(t)).Select(t => t.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).ToList()).ToList();
        }
        public List<List<string>> Tokenize(string input)
        {
            var tokens = Regex.Split(input, "([,;.]|[+\-*/%^!~]|[<>=]=|!=|==|&&|\\|\\||\\w+|//.*?\n|/\\*.*?\\*/)");
            return tokens.Where(t => !string.IsNullOrWhiteSpace(t)).Select(t => t.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).ToList()).ToList();
        }
    }
}
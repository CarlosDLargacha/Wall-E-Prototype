using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE { 
    public class Aritmetica
    {
        internal static string Evaluar(string expression)
        {
            // Se eliminan los espacios en blanco de la expresi�n
            expression = expression.Replace(" ", "");
            expression = expression.Replace("-(", "-1*(");
            expression = expression.Replace("-", "-1*");
            //int error = Validar_Aritmetica.ValidarExpresion(expression);
            //if (Validar_Aritmetica.ValidarExpresion(expression) != -1)
            //{
            //    if (expression[error] == '(')
            //    {
            //        return "! SYNTAX ERROR: Missing closing parenthesis";
            //    }
            //    if (expression[error] == ')')
            //    {
            //        return "! SYNTAX ERROR: Missing open parenthesis";
            //    }
            //    if (expression[error] == ')')
            //    {
            //        return "! SYNTAX ERROR: Missing open parenthesis";
            //    }
            //    if (expression[error].ToString().Any(Char.IsLetter))
            //    {
            //        return "! LEXICAL ERROR: " + expression[error].ToString()+" is not valid token.";
            //    }
            //    else { return "! SYNTAX ERROR: Missing operator"; }

            //}


            // Se crea una pila para almacenar los n�meros
            Stack<double> numbers = new Stack<double>();

            // Se crea una pila para almacenar los operadores
            Stack<char> operators = new Stack<char>();

            // Se recorre la expresi�n caracter por caracter
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                // Si el caracter es un d�gito o un punto decimal, se forma el n�mero completo y se a�ade a la pila de n�meros
                if (char.IsDigit(c) || c == '.')
                {
                    string number = c.ToString();

                    while (i + 1 < expression.Length && (char.IsDigit(expression[i + 1]) || expression[i + 1] == '.'))
                    {
                        number += expression[i + 1];
                        i++;
                    }

                    numbers.Push(double.Parse(number));
                }
                // Si el caracter es un signo menos y el anterior no es un d�gito ni un par�ntesis derecho, se trata de un n�mero negativo
                else if (c == '-' && (i == 0 || !char.IsDigit(expression[i - 1]) && expression[i - 1] != ')'))
                {
                    string number = c.ToString();

                    while (i + 1 < expression.Length && (char.IsDigit(expression[i + 1]) || expression[i + 1] == '.'))
                    {
                        number += expression[i + 1];
                        i++;
                    }

                    numbers.Push(double.Parse(number));
                }
                // Si el caracter es un par�ntesis izquierdo, se a�ade a la pila de operadores
                else if (c == '(')
                {
                    operators.Push(c);
                }
                // Si el caracter es un par�ntesis derecho, se resuelven las operaciones dentro del par�ntesis
                else if (c == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        PerformOperation(numbers, operators);
                    }

                    // Se elimina el par�ntesis izquierdo de la pila de operadores
                    operators.Pop();
                }
                // Si el caracter es un operador (+, -, *, /, ^), se resuelven las operaciones anteriores con mayor o igual precedencia
                else if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '%')
                {
                    while (operators.Count > 0 && HasPrecedence(c, operators.Peek()))
                    {
                        PerformOperation(numbers, operators);
                    }

                    // Se a�ade el operador actual a la pila de operadores
                    operators.Push(c);
                }
            }


            // Se resuelven las operaciones restantes en la pila
            while (operators.Count > 0)
            {
                PerformOperation(numbers, operators);
            }

            // Se devuelve el resultado final en forma de string
            return numbers.Pop().ToString();
        }

        // M�todo que realiza una operaci�n aritm�tica entre dos n�meros seg�n el operador dado
        // Los n�meros y el operador se extraen de las pilas correspondientes
        // El resultado se a�ade a la pila de n�meros
        static void PerformOperation(Stack<double> numbers, Stack<char> operators)
        {
            // Se extrae el operador de la pila de operadores
            char op = operators.Pop();

            // Se extraen los dos n�meros de la pila de n�meros
            double b = numbers.Pop();
            double a = numbers.Pop();

            // Se realiza la operaci�n seg�n el operador y se almacena el resultado
            double result = 0;

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                case '%':
                    result = a % b;
                    break;
                case '^':
                    result = Math.Pow(a, b);
                    break;
            }

            // Se a�ade el resultado a la pila de n�meros
            numbers.Push(result);
        }

        // M�todo que determina si el operador 1 tiene mayor o igual precedencia que el operador 2
        // La precedencia es: par�ntesis > potencia > multiplicaci�n y divisi�n > suma y resta
        // El m�todo devuelve true si el operador 1 tiene mayor o igual precedencia que el operador 2, y false en caso contrario
        static bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }

            if ((op1 == '*' || op1 == '/' || op1 == '%') && (op2 == '+' || op2 == '-'))
            {
                return false;
            }

            if (op1 == '^' && op2 != '^')
            {
                return false;
            }

            return true;
        }
    }
}
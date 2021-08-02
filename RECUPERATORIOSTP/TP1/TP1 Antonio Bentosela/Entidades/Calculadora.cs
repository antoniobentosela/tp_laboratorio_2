using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            double resultado = 0;
            char.TryParse(operador, out char result);
            string operadorS = ValidarOperador(result);

            switch (operadorS) {

                case "+": 
                    resultado = n1 + n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    resultado = n1 / n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
            }            
            return resultado;
        }

       private static string ValidarOperador(char operador)
       {
            if(operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                return "+";
            }
            else
            {
                return operador.ToString();
            }
        
       }
    }
}

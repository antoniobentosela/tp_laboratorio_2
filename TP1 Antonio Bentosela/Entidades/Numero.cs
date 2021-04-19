using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            if (double.TryParse(numero, out double result))
            {
                this.numero = result;
            }
        }

        private double ValidarNumero(string strNumero)
        {
            if (double.TryParse(strNumero, out double result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        private static bool EsBinario(string binario)
        {
            bool resultado = false;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '0' || binario[i] == '1')
                {
                    resultado = true;
                }
            }

            return resultado;
        }
        public static string BinarioDecimal(string binario)
        {
            if (EsBinario(binario)) {

                int numero = 0;
                int digito = 0;
                const int DIVISOR = 10;

                int a = Convert.ToInt32(binario);

                for (long i = a, j = 0; i > 0; i /= DIVISOR, j++)
                {
                    digito = (int)i % DIVISOR;
                    numero += digito * (int)Math.Pow(2, j);
                }

                return numero.ToString();
            }
            else
            {
                return "Valor Invalido";
            }
        }

        public static string DecimalBinario(double numero)
        {
            String cadena = "";
            if (numero > 0)
            {

                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }

            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
            return cadena;
        }

        public static string DecimalBinario(string numero)
        {
            double.TryParse(numero, out double result);
            return DecimalBinario(result); ;
        }

        public static double operator -(Numero n1, Numero n2) 
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

    }
}

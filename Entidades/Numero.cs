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

        public string Set
        {
            set { this.numero = ValidarNumero(value); }
        }

        #region Constructores
        public Numero ()
        {
            this.numero = 0;
                    
        }

        public Numero(string strNumero)
        {
            this.Set = strNumero;

        }

        public Numero(double num):this(num.ToString())
        {
            

        }

        #endregion

        private double ValidarNumero (string strNumero)
        {
            double num;
            bool parse;
           
            parse = Double.TryParse(strNumero, out num);

            if(parse == false)
            {
                return 0;

            }
            else
            {

                return num = Double.Parse(strNumero);
            }

        }

        private static bool EsBinario(string strNumero)
        {
            bool parse = false;
            

            for(int i = 0; i < strNumero.Length; i++){

                if(strNumero[i] != '0' && strNumero[i] != '1')
                {
                    return parse;

                }
                else
                {
                    parse = true;
                }
                

            }

            return parse;
   
        }

        public static string BinarioDecimal(string binario)
        {
            string retornoBinario;

            if(EsBinario(binario) == true)
            {
                retornoBinario = Convert.ToInt32(binario, 2).ToString();

            }
            else
            {
                retornoBinario = "Valor invalido";
            }

            return retornoBinario;

        }

        public static string DecimalBinario(string numBin)
        {
            Numero numD = new Numero(numBin);
            double numDecimal = Math.Floor(numD.numero);
            string retornoDeciBinario = string.Empty;
            string errorMsg = "Valor Invalido";

            if (numDecimal > 0)
            {
                while (numDecimal != 0)
                {
                    if (numDecimal % 2 == 0)
                    {
                        retornoDeciBinario = "0" + retornoDeciBinario;
                    }
                    else
                    {
                        retornoDeciBinario = "1" + retornoDeciBinario;
                    }
                    numDecimal /= 2;
                    numDecimal = Math.Floor(numDecimal);
                }
            }
            else
            {
                retornoDeciBinario = errorMsg;
            }

            return retornoDeciBinario;
        }

        public static Double operator +(Numero num1, Numero num2)
        {

            return num1.numero + num2.numero;

        }

        public static Double operator -(Numero num1, Numero num2)
        {

            return num1.numero - num2.numero;

        }

        public static Double operator /(Numero num1, Numero num2)
        {

            double retorno;

            if(num2.numero == 0)
            {
                retorno = double.MinValue;

            }
            else
            {

                retorno = num1.numero / num2.numero;
            }

            return retorno;

        }

        public static Double operator *(Numero num1, Numero num2)
        {

            return num1.numero * num2.numero;

        }





    }
}

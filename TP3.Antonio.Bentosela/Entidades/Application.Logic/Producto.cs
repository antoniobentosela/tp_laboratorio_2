﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Helado))]
    [XmlInclude(typeof(Caramelos))]
    public abstract class Producto
    {
        protected string codigoBarra;
        protected string nombre;

        #region Propiedades        
        public abstract int Stock { get; set; }
        public abstract bool EsCongelado { get; }
        public string CodigoBarra
        {
            get { return this.codigoBarra; }
            set { this.codigoBarra = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        #endregion

        #region Constructores
        public Producto() { }

        public Producto(string nombre)
        {
            this.nombre = nombre;
        }

        public Producto(string nombre, string codigoBarra)
            : this(nombre)
        {
            this.CodigoBarra = codigoBarra;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo sobreescrito ToString
        /// </summary>
        /// <returns>Retorna el atributo nombre de la clase Producto</returns>
        public override string ToString()
        {
            return this.nombre;
        }

        /// <summary>
        /// Este metodo se encarga de Crear un StringBuilder con toda la informacion del Producto
        /// </summary>
        /// <returns>Retorna el StringBuilder en formato string</returns>
        public virtual string Informacion()
        {
            string congelado;

            StringBuilder sb = new StringBuilder();

            if (this.EsCongelado) { congelado = "SI"; } else { congelado = "NO"; };

            sb.AppendLine($"Nombre:{this.nombre}");
            sb.AppendLine($"Es Congelado:{congelado}");
            sb.AppendFormat("Codigo De Barras: {0} \n", codigoBarra);

            return sb.ToString();
        }
        #endregion

        #region Operator
        /// <summary>
        /// Operador igualdad, que se encarga de comparar dos productos por su nombre
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Retorna true si los productos son iguales y false si son distintos</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.Nombre == p2.Nombre && p1.CodigoBarra == p2.CodigoBarra)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Operador distinto, que se encarga de comprar dos productos por su nombre
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Retorna true si los productos son distintos y false si son iguales</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);

        }
        #endregion
    }
}

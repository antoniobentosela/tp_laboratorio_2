﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paleta : Producto
    {
        private int stockPaletas;

        #region Propiedades
        public override int Stock
        {
            get { return this.stockPaletas; }
            set { this.stockPaletas = value; }
        }
        public override bool EsCongelado 
        {
            get { return true; }       
        }
        #endregion

        #region Constructores
        public Paleta() 
        { 
        
        }

        public Paleta(string nombre, string codigoBarra)    
            : base(nombre, codigoBarra)
        {
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Crea un StringBuilder con los datos del producto y su stock.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{base.Informacion()}");
            sb.AppendLine($"Stock: {this.Stock}");

            return sb.ToString();
        }
        #endregion
    }
}

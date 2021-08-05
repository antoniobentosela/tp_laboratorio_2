using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cucurucho : Producto
    {
        private int stockCucuruchos;
       
        #region Propiedades
        public override int Stock
        {
            get { return this.stockCucuruchos; }
            set { this.stockCucuruchos = value; }
        }

        #endregion

        #region Constructores

        public Cucurucho() { }

        public Cucurucho(string nombre, string codigoBarra)
          : base(nombre, codigoBarra)
        {
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Crea un StringBuilder con los datos del producto y su stock.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>

        public override string Informar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{base.Informar()}");
            sb.AppendLine($"Stock: {this.Stock}");

            return sb.ToString();
        }
        #endregion
    }
}

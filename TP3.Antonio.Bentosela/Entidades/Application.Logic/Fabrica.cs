﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        public List<Producto> productos;

        #region Constructores
        public Fabrica()
        {
            this.productos = new List<Producto>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Incrementa el stock del producto que le llega por parmetro.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Devuelve true si se pudo fabricar, false si no se pudo fabricar.</returns>
        public static bool FabricarProducto(Producto p)
        {
             if (!(p is null))
             {
                 p.Stock++;
                 return true;
             }
             else
             {
                 throw new LogicException("No existe ningun producto");
             }          
        }
        /// <summary>
        /// Crea un stringbuilder con los datos de todos los productos.
        /// </summary>
        /// <param name="f"></param>
        /// <returns>Devuelve un string con todos los datos</returns>
        public static string InformeDeProductos(Fabrica f)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto info in f.productos)
            {
                sb.AppendLine("Producto:" + info.Informacion());
            }
            return sb.ToString();
        }
        #endregion
    }
}

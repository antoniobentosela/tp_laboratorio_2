using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class MetodosFabrica
    {
        [TestMethod]
        public void InformarProductos()
        {
            //arrange
            Paleta producto = new Paleta("Producto de Test", "1234");
            Fabrica fabrica = new Fabrica();

            //Act
            fabrica.productos.Add(producto);
            string info = Fabrica.InformeDeProductos(fabrica);

            //Assert
            Assert.IsTrue(info is string);
            Assert.IsNotNull(info); 
        }
        [TestMethod]
        public void FabricarProducto()
        {
            //arrange
            Paleta producto = new Paleta("Producto de Test", "1234");
            Fabrica fabrica = new Fabrica();

            //Act
            fabrica.FabricarProducto(producto);
            
            //Assert 
            Assert.IsTrue(producto.Stock > 0);
        }
        [TestMethod]
        [ExpectedException(typeof(LogicException))]
        public void FabricarProductoNull()
        {
            //arrange
            Fabrica fabrica = new Fabrica();
            //Act
            fabrica.FabricarProducto(null);
        }
    }
   

}

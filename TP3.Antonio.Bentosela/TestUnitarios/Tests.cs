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
            Helado producto = new Helado("Producto de Test", "1234");
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
            Helado producto = new Helado("Producto de Test", "1234");
            Fabrica fabrica = new Fabrica();

            //Act
            Fabrica.FabricarProducto(producto);
            
            //Assert 
            Assert.IsTrue(producto.Stock > 0);
        }
        [TestMethod]
        [ExpectedException(typeof(LogicException))]
        public void FabricarProductoNull()
        {
            //Act
            Fabrica.FabricarProducto(null);
        }
    }
    [TestClass]
    public class MetodosProducto
    {
        [TestMethod]
        public void OperadorIgualdad()
        {
            //arrange
            Helado producto = new Helado("Producto de Test", "1234");
            Helado producto2 = new Helado("Producto de Test", "1234");

            //Act
            bool respuesta = producto == producto2;

            //Assert
            Assert.IsTrue(respuesta);
        }
        
        [TestMethod]
        public void OperadorDesigualdad()
        {
            //arrange
            Helado producto = new Helado("Producto de Test", "1234");
            Helado producto2 = new Helado("Producto de Test2", "1234");

            //Act
            bool respuesta = producto == producto2;

            //Assert
            Assert.IsFalse(respuesta);
        }
    }

}

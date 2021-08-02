using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{

    [TestClass]
    public class MetodosProducto
    {
        [TestMethod]
        public void OperadorIgualdad()
        {
            //arrange
            Paleta producto = new Paleta("Producto de Test", "1234");
            Paleta producto2 = new Paleta("Producto de Test", "1234");

            //Act
            bool respuesta = producto == producto2;

            //Assert
            Assert.IsTrue(respuesta);
        }
        
        [TestMethod]
        public void OperadorDesigualdad()
        {
            //arrange
            Paleta producto = new Paleta("Producto de Test", "1234");
            Paleta producto2 = new Paleta("Producto de Test2", "1234");

            //Act
            bool respuesta = producto == producto2;

            //Assert
            Assert.IsFalse(respuesta);
        }
    }

}

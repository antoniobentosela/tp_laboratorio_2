using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Paleta p1 = new Paleta("Paleta Dulce De Leche", "222K3ST");
            Paleta p2 = new Paleta("Paleta Chocolate", "RTY5678");
            Cucurucho p3 = new Cucurucho("Cucurucho Pico Dulce", "HJ1T459");
            Cucurucho p4 = new Cucurucho("Cucurucho Bon o Bon", "ZJJTT11");

            p1.Stock++;
            p2.Stock = 5;
            p3.Stock = 200;

            Console.WriteLine("Muestro los datos del primer producto:\n");

            Console.WriteLine(p1.Informar());

            Console.WriteLine("---------------------------------------\n");

            Fabrica fabrica = new Fabrica();

            fabrica.productos.Add(p1);
            fabrica.productos.Add(p2);
            fabrica.productos.Add(p3);
            fabrica.productos.Add(p4);

            Console.WriteLine("Muestro los datos de todos los productos:\n");

            Console.WriteLine(Fabrica.InformarProductos(fabrica));

            Console.ReadKey();



        }
    }
}

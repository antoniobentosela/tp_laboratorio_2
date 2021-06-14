using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormFabricaArcor
{
    public partial class FabricaArcor : Form
    {
        public Fabrica fabrica;

        public FabricaArcor()
        {
            InitializeComponent();
            fabrica = new Fabrica();
        }

        /// <summary>
        /// Metodo que se encarga de Agregar itemas a la lista de productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabricacion_Load(object sender, EventArgs e)
        {
            Helado p1 = new Helado("Palito Bombon", "222K3ST");
            Helado p2 = new Helado("Bon o Bon(Helado)", "RTY5678");
            Caramelos p3 = new Caramelos("Pico Dulce", "HJ1T459");
            Caramelos p4 = new Caramelos("Bon o Bon(Golosina)", "ZJJTT11");

            this.ListaProductos.Items.Add(p1);
            this.ListaProductos.Items.Add(p2);
            this.ListaProductos.Items.Add(p3);
            this.ListaProductos.Items.Add(p4);
            fabrica.productos.Add(p1);
            fabrica.productos.Add(p2);
            fabrica.productos.Add(p3);
            fabrica.productos.Add(p4);
        }
        /// <summary>
        /// Fabrica un producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Producto p = this.ListaProductos.SelectedItem as Producto;
            try
            {
                Fabrica.FabricarProducto(p);
                MessageBox.Show($"Producto fabricado!! {p.ToString()}");
            }
            catch (LogicException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        /// <summary>
        /// Muestra el producto seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Producto p = this.ListaProductos.SelectedItem as Producto;
            try
            {
                Listado.Text = p.Informacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        /// <summary>
        /// Guarda un archivo de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Texto lista = new Texto();

            try
            {
                lista.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ArchivoDeTexto.txt", fabrica.productos);
                MessageBox.Show("Se guardo el archivo de texto correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Guarda un archivo xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<List<Producto>> lista = new Xml<List<Producto>>();

            try
            {
                lista.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ArchivoXml.xml", fabrica.productos);
                MessageBox.Show("Se guardo el archivo xml correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Muestra todos los productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                Listado.Text = Fabrica.InformeDeProductos(fabrica);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

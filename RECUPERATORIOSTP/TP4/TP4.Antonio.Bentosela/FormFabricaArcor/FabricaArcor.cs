using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Application.Logic;

namespace FormFabricaArcor
{
    public partial class FabricaArcor : Form
    {
        public Fabrica fabrica;
        public Producto producto;
        public DBConnection conexion;
        public int contador = 0;

        public FabricaArcor()
        {
            InitializeComponent();
            fabrica = new Fabrica();
            this.label1.Text = "Simulacion de Fabricacion";
        }

        /// <summary>
        /// Metodo que se encarga de Agregar itemas a la lista de productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabricacion_Load(object sender, EventArgs e)
        {
            Paleta p1 = new Paleta("Paleta Dulce De Leche", "222K3ST");
            Paleta p2 = new Paleta("Paleta Chocolate", "RTY5678");
            Cucurucho p3 = new Cucurucho("Cucurucho Pico Dulce", "HJ1T459");
            Cucurucho p4 = new Cucurucho("Cucurucho Bon o Bon", "ZJJTT11");

            p1.InformaEstado += proInformarEstado;
            p2.InformaEstado += proInformarEstado;
            p3.InformaEstado += proInformarEstado;
            p4.InformaEstado += proInformarEstado;

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
            try
            {
                producto = this.ListaProductos.SelectedItem as Producto;              
                fabrica.FabricarProducto(this.ListaProductos.SelectedItem as Producto);
                contador++;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        /// <summary>
        /// Metodo que se encarga de cambiar el label dependiendo el estado del producto para informar el paso a paso de la fabricacion.
        /// </summary>
        public void ActualizarEstados()
        {

            switch (producto.Estado)
            {
                case Producto.EEstado.RecolectandoIngredientes:
                    this.label1.Text = "Recolectando Ingredientes...";
                    break;
                case Producto.EEstado.Elaborando:
                    this.label1.Text = "Elaborando...";
                    break;
                case Producto.EEstado.Empaquetando:
                    this.label1.Text = "Empaquetando...";                                                    
                    break;
                case Producto.EEstado.Fabricado:
                    this.label1.Text = "Simulacion de Fabricacion...";
                    MessageBox.Show("Producto Fabricado con exito!");
                    break;
                default:
                    break;
            }           
        }

        /// <summary>
        /// Metodo que se encarga de cambiar el hilo secundario dependiendo la instancia en la que me encuentro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void proInformarEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Producto.DelegadoEstado d = new Producto.DelegadoEstado(proInformarEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
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
                Listado.Text = p.Informar();
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
                Listado.Text = Fabrica.InformarProductos(fabrica);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FabricaArcor_FormClosing(object sender, FormClosingEventArgs e)
        {
            fabrica.CerrarHilo();
        }

        private void btnGuardarSql_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Producto p in fabrica.productos) 
                {                 
                    DBConnection.GuardarMaterial(p);                   
                }

                MessageBox.Show("Se guardaron los datos correctamente.");
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

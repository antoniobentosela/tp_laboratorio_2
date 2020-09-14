using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

    

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {

            lblResultado.ResetText();
            comboBox1.ResetText();
            textBox1.Clear();
            textBox2.Clear();

        }

        private static double Operar (string numero1, string numero2, string operador)
        {
            Numero aux1 = new Numero(numero1);
            Numero aux2 = new Numero(numero2);

            return Calculadora.Operar(aux1, aux2, operador);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = FormCalculadora.Operar(textBox1.Text, textBox2.Text, comboBox1.Text).ToString();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        
    }

  
}

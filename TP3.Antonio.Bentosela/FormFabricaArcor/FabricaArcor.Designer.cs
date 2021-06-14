namespace FormFabricaArcor
{
    partial class FabricaArcor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaProductos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.RichTextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaProductos
            // 
            this.ListaProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListaProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(12, 12);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(306, 303);
            this.ListaProductos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fabricar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // Listado
            // 
            this.Listado.BackColor = System.Drawing.SystemColors.MenuText;
            this.Listado.ForeColor = System.Drawing.SystemColors.Window;
            this.Listado.Location = new System.Drawing.Point(357, 12);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(313, 303);
            this.Listado.TabIndex = 2;
            this.Listado.Text = "";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrar.Location = new System.Drawing.Point(12, 404);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(306, 55);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Producto";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(364, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(306, 74);
            this.button3.TabIndex = 4;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(364, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(306, 74);
            this.button4.TabIndex = 5;
            this.button4.Text = "Xml";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrarTodos.Location = new System.Drawing.Point(12, 465);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(306, 55);
            this.btnMostrarTodos.TabIndex = 6;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // FabricaArcor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(697, 571);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaProductos);
            this.Name = "FabricaArcor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FabricaArcor";
            this.Load += new System.EventHandler(this.FrmFabricacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Listado;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}


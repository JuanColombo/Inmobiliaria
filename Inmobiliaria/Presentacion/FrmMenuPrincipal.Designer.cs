
namespace Inmobiliaria
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.BtnNuevoPropietario = new System.Windows.Forms.Button();
            this.BtnNuevaPropiedad = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuVerEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuPropietarios = new System.Windows.Forms.ToolStripMenuItem();
            this.SunMnuPropiedades = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListados = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuListadoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoCliente.Location = new System.Drawing.Point(631, 27);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(147, 51);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // BtnNuevoPropietario
            // 
            this.BtnNuevoPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoPropietario.BackColor = System.Drawing.Color.LightGreen;
            this.BtnNuevoPropietario.Location = new System.Drawing.Point(631, 84);
            this.BtnNuevoPropietario.Name = "BtnNuevoPropietario";
            this.BtnNuevoPropietario.Size = new System.Drawing.Size(147, 51);
            this.BtnNuevoPropietario.TabIndex = 1;
            this.BtnNuevoPropietario.Text = "Nuevo Propietario";
            this.BtnNuevoPropietario.UseVisualStyleBackColor = false;
            this.BtnNuevoPropietario.Click += new System.EventHandler(this.BtnNuevoPropietario_Click);
            // 
            // BtnNuevaPropiedad
            // 
            this.BtnNuevaPropiedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevaPropiedad.BackColor = System.Drawing.Color.LightGreen;
            this.BtnNuevaPropiedad.Location = new System.Drawing.Point(631, 141);
            this.BtnNuevaPropiedad.Name = "BtnNuevaPropiedad";
            this.BtnNuevaPropiedad.Size = new System.Drawing.Size(147, 51);
            this.BtnNuevaPropiedad.TabIndex = 2;
            this.BtnNuevaPropiedad.Text = "Nueva Propiedad";
            this.BtnNuevaPropiedad.UseVisualStyleBackColor = false;
            this.BtnNuevaPropiedad.Click += new System.EventHandler(this.BtnNuevaPropiedad_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(631, 198);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(147, 51);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuVerEditar,
            this.MnuListados});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuVerEditar
            // 
            this.MnuVerEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMnuClientes,
            this.SubMnuPropietarios,
            this.SunMnuPropiedades});
            this.MnuVerEditar.Name = "MnuVerEditar";
            this.MnuVerEditar.Size = new System.Drawing.Size(76, 20);
            this.MnuVerEditar.Text = "Ver / Editar";
            // 
            // SubMnuClientes
            // 
            this.SubMnuClientes.Name = "SubMnuClientes";
            this.SubMnuClientes.Size = new System.Drawing.Size(139, 22);
            this.SubMnuClientes.Text = "Clientes";
            this.SubMnuClientes.Click += new System.EventHandler(this.SubMnuClientes_Click);
            // 
            // SubMnuPropietarios
            // 
            this.SubMnuPropietarios.Name = "SubMnuPropietarios";
            this.SubMnuPropietarios.Size = new System.Drawing.Size(139, 22);
            this.SubMnuPropietarios.Text = "Propietarios";
            this.SubMnuPropietarios.Click += new System.EventHandler(this.SubMnuPropietarios_Click);
            // 
            // SunMnuPropiedades
            // 
            this.SunMnuPropiedades.Name = "SunMnuPropiedades";
            this.SunMnuPropiedades.Size = new System.Drawing.Size(139, 22);
            this.SunMnuPropiedades.Text = "Propiedades";
            this.SunMnuPropiedades.Click += new System.EventHandler(this.SunMnuPropiedades_Click);
            // 
            // MnuListados
            // 
            this.MnuListados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMnuListadoClientes});
            this.MnuListados.Name = "MnuListados";
            this.MnuListados.Size = new System.Drawing.Size(62, 20);
            this.MnuListados.Text = "Listados";
            // 
            // SubMnuListadoClientes
            // 
            this.SubMnuListadoClientes.Name = "SubMnuListadoClientes";
            this.SubMnuListadoClientes.Size = new System.Drawing.Size(116, 22);
            this.SubMnuListadoClientes.Text = "Clientes";
            this.SubMnuListadoClientes.Click += new System.EventHandler(this.SubMnuListadoClientes_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNuevaPropiedad);
            this.Controls.Add(this.BtnNuevoPropietario);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.Text = "Inmobiliaria Julian Daniel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button BtnNuevoPropietario;
        private System.Windows.Forms.Button BtnNuevaPropiedad;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuVerEditar;
        private System.Windows.Forms.ToolStripMenuItem SubMnuClientes;
        private System.Windows.Forms.ToolStripMenuItem SubMnuPropietarios;
        private System.Windows.Forms.ToolStripMenuItem SunMnuPropiedades;
        private System.Windows.Forms.ToolStripMenuItem MnuListados;
        private System.Windows.Forms.ToolStripMenuItem SubMnuListadoClientes;
    }
}


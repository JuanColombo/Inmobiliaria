
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
            this.SubMnuListadoPropietarios = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnClientes = new System.Windows.Forms.ToolStripButton();
            this.BtnPropiedades = new System.Windows.Forms.ToolStripButton();
            this.BtnPropietarios = new System.Windows.Forms.ToolStripButton();
            this.BtnAlquilerVenta = new System.Windows.Forms.ToolStripButton();
            this.btnPropietariosyPropiedades = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoCliente.Location = new System.Drawing.Point(742, 74);
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
            this.BtnNuevoPropietario.Location = new System.Drawing.Point(742, 131);
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
            this.BtnNuevaPropiedad.Location = new System.Drawing.Point(742, 188);
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
            this.BtnSalir.Location = new System.Drawing.Point(742, 303);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(147, 51);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuVerEditar,
            this.MnuListados,
            this.gestionDeUsuariosToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
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
            this.SubMnuListadoClientes,
            this.SubMnuListadoPropietarios});
            this.MnuListados.Name = "MnuListados";
            this.MnuListados.Size = new System.Drawing.Size(62, 20);
            this.MnuListados.Text = "Listados";
            // 
            // SubMnuListadoClientes
            // 
            this.SubMnuListadoClientes.Name = "SubMnuListadoClientes";
            this.SubMnuListadoClientes.Size = new System.Drawing.Size(137, 22);
            this.SubMnuListadoClientes.Text = "Clientes";
            this.SubMnuListadoClientes.Click += new System.EventHandler(this.SubMnuListadoClientes_Click);
            // 
            // SubMnuListadoPropietarios
            // 
            this.SubMnuListadoPropietarios.Name = "SubMnuListadoPropietarios";
            this.SubMnuListadoPropietarios.Size = new System.Drawing.Size(137, 22);
            this.SubMnuListadoPropietarios.Text = "Propietarios";
            this.SubMnuListadoPropietarios.Click += new System.EventHandler(this.SubMnuListadoPropietarios_Click);
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUsuario,
            this.MnuCambioContraseña});
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion De Usuarios";
            // 
            // MnuUsuario
            // 
            this.MnuUsuario.Name = "MnuUsuario";
            this.MnuUsuario.Size = new System.Drawing.Size(195, 22);
            this.MnuUsuario.Text = "Usuarios";
            this.MnuUsuario.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MnuCambioContraseña
            // 
            this.MnuCambioContraseña.Name = "MnuCambioContraseña";
            this.MnuCambioContraseña.Size = new System.Drawing.Size(195, 22);
            this.MnuCambioContraseña.Text = "Cambio de Contraseña";
            this.MnuCambioContraseña.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuParametros});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // MnuParametros
            // 
            this.MnuParametros.Name = "MnuParametros";
            this.MnuParametros.Size = new System.Drawing.Size(134, 22);
            this.MnuParametros.Text = "Parametros";
            this.MnuParametros.Click += new System.EventHandler(this.parametrosToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClientes,
            this.BtnPropiedades,
            this.BtnPropietarios,
            this.BtnAlquilerVenta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 47);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnClientes
            // 
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(53, 44);
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnPropiedades
            // 
            this.BtnPropiedades.Image = ((System.Drawing.Image)(resources.GetObject("BtnPropiedades.Image")));
            this.BtnPropiedades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPropiedades.Name = "BtnPropiedades";
            this.BtnPropiedades.Size = new System.Drawing.Size(76, 44);
            this.BtnPropiedades.Text = "Propiedades";
            this.BtnPropiedades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPropiedades.Click += new System.EventHandler(this.BtnPropiedades_Click);
            // 
            // BtnPropietarios
            // 
            this.BtnPropietarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnPropietarios.Image")));
            this.BtnPropietarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPropietarios.Name = "BtnPropietarios";
            this.BtnPropietarios.Size = new System.Drawing.Size(74, 44);
            this.BtnPropietarios.Text = "Propietarios";
            this.BtnPropietarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPropietarios.Click += new System.EventHandler(this.BtnPropietarios_Click);
            // 
            // BtnAlquilerVenta
            // 
            this.BtnAlquilerVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlquilerVenta.Image")));
            this.BtnAlquilerVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlquilerVenta.Name = "BtnAlquilerVenta";
            this.BtnAlquilerVenta.Size = new System.Drawing.Size(94, 44);
            this.BtnAlquilerVenta.Text = "Alquiler o Venta";
            this.BtnAlquilerVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAlquilerVenta.Click += new System.EventHandler(this.BtnAlquilerVenta_Click);
            // 
            // btnPropietariosyPropiedades
            // 
            this.btnPropietariosyPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPropietariosyPropiedades.BackColor = System.Drawing.Color.LightGreen;
            this.btnPropietariosyPropiedades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPropietariosyPropiedades.Location = new System.Drawing.Point(742, 246);
            this.btnPropietariosyPropiedades.Name = "btnPropietariosyPropiedades";
            this.btnPropietariosyPropiedades.Size = new System.Drawing.Size(147, 51);
            this.btnPropietariosyPropiedades.TabIndex = 3;
            this.btnPropietariosyPropiedades.Text = "Propietarios y Propiedades";
            this.btnPropietariosyPropiedades.UseVisualStyleBackColor = false;
            this.btnPropietariosyPropiedades.Click += new System.EventHandler(this.btnPropietariosyPropiedades_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(901, 540);
            this.Controls.Add(this.btnPropietariosyPropiedades);
            this.Controls.Add(this.toolStrip1);
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
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem SubMnuListadoPropietarios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnClientes;
        private System.Windows.Forms.ToolStripButton BtnPropiedades;
        private System.Windows.Forms.ToolStripButton BtnPropietarios;
        private System.Windows.Forms.ToolStripButton BtnAlquilerVenta;
        private System.Windows.Forms.Button btnPropietariosyPropiedades;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuCambioContraseña;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuParametros;
    }
}


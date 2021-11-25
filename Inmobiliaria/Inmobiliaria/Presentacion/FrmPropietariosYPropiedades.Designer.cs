namespace Inmobiliaria.Presentacion
{
    partial class FrmPropietariosYPropiedades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPropietarios = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.gridPropiedades = new System.Windows.Forms.DataGridView();
            this.BtnEditarPropiedad = new System.Windows.Forms.Button();
            this.BtnAgregarPropiedad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPropietarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPropietarios
            // 
            this.gridPropietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPropietarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPropietarios.Location = new System.Drawing.Point(12, 12);
            this.gridPropietarios.Name = "gridPropietarios";
            this.gridPropietarios.ReadOnly = true;
            this.gridPropietarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPropietarios.Size = new System.Drawing.Size(640, 177);
            this.gridPropietarios.TabIndex = 0;
            this.gridPropietarios.Text = "dataGridView1";
            this.gridPropietarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPropietarios_CellEnter);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(658, 12);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 30);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(744, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(83, 30);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(833, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 30);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(670, 68);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(103, 15);
            this.LblBuscar.TabIndex = 4;
            this.LblBuscar.Text = "Buscar Propietario";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(670, 86);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(249, 23);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // gridPropiedades
            // 
            this.gridPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPropiedades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPropiedades.Location = new System.Drawing.Point(12, 223);
            this.gridPropiedades.Name = "gridPropiedades";
            this.gridPropiedades.ReadOnly = true;
            this.gridPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPropiedades.Size = new System.Drawing.Size(640, 177);
            this.gridPropiedades.TabIndex = 0;
            this.gridPropiedades.Text = "dataGridView1";
            // 
            // BtnEditarPropiedad
            // 
            this.BtnEditarPropiedad.Location = new System.Drawing.Point(263, 417);
            this.BtnEditarPropiedad.Name = "BtnEditarPropiedad";
            this.BtnEditarPropiedad.Size = new System.Drawing.Size(105, 30);
            this.BtnEditarPropiedad.TabIndex = 2;
            this.BtnEditarPropiedad.Text = "&Editar Propiedad";
            this.BtnEditarPropiedad.UseVisualStyleBackColor = true;
            this.BtnEditarPropiedad.Click += new System.EventHandler(this.BtnEditarPropiedad_Click);
            // 
            // BtnAgregarPropiedad
            // 
            this.BtnAgregarPropiedad.Location = new System.Drawing.Point(82, 417);
            this.BtnAgregarPropiedad.Name = "BtnAgregarPropiedad";
            this.BtnAgregarPropiedad.Size = new System.Drawing.Size(123, 30);
            this.BtnAgregarPropiedad.TabIndex = 1;
            this.BtnAgregarPropiedad.Text = "&Agregar Propiedad";
            this.BtnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.BtnAgregarPropiedad.Click += new System.EventHandler(this.BtnAgregarPropiedad_Click);
            // 
            // FrmPropietariosYPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 479);
            this.Controls.Add(this.BtnAgregarPropiedad);
            this.Controls.Add(this.BtnEditarPropiedad);
            this.Controls.Add(this.gridPropiedades);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.gridPropietarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPropietariosYPropiedades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propietarios y sus propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.gridPropietarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPropietarios;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView gridPropiedades;
        private System.Windows.Forms.Button BtnEditarPropiedad;
        private System.Windows.Forms.Button BtnAgregarPropiedad;
    }
}
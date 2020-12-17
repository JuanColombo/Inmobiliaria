
namespace Inmobiliaria.Presentacion
{
    partial class FrmCompraAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraAlquiler));
            this.CboAlquilerVenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSeleccionPropiedad = new System.Windows.Forms.Label();
            this.LblSeleccionCliente = new System.Windows.Forms.Label();
            this.LblInicioVenta = new System.Windows.Forms.Label();
            this.LblFechaDeFin = new System.Windows.Forms.Label();
            this.LblPrecioAlquier = new System.Windows.Forms.Label();
            this.LblPrecioVenta = new System.Windows.Forms.Label();
            this.CboPropiedad = new System.Windows.Forms.ComboBox();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.DtpFechaInicioOVenta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.NumUpDownAlquiler = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownVenta = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboAlquilerVenta
            // 
            this.CboAlquilerVenta.FormattingEnabled = true;
            this.CboAlquilerVenta.Location = new System.Drawing.Point(172, 75);
            this.CboAlquilerVenta.Name = "CboAlquilerVenta";
            this.CboAlquilerVenta.Size = new System.Drawing.Size(153, 23);
            this.CboAlquilerVenta.TabIndex = 0;
            this.CboAlquilerVenta.SelectedValueChanged += new System.EventHandler(this.CboAlquilerVenta_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Desea realizar una?";
            // 
            // LblSeleccionPropiedad
            // 
            this.LblSeleccionPropiedad.AutoSize = true;
            this.LblSeleccionPropiedad.Location = new System.Drawing.Point(21, 131);
            this.LblSeleccionPropiedad.Name = "LblSeleccionPropiedad";
            this.LblSeleccionPropiedad.Size = new System.Drawing.Size(135, 15);
            this.LblSeleccionPropiedad.TabIndex = 2;
            this.LblSeleccionPropiedad.Text = "Seleccione la propiedad:";
            // 
            // LblSeleccionCliente
            // 
            this.LblSeleccionCliente.AutoSize = true;
            this.LblSeleccionCliente.Location = new System.Drawing.Point(21, 173);
            this.LblSeleccionCliente.Name = "LblSeleccionCliente";
            this.LblSeleccionCliente.Size = new System.Drawing.Size(113, 15);
            this.LblSeleccionCliente.TabIndex = 3;
            this.LblSeleccionCliente.Text = "Seleccione el cliente";
            // 
            // LblInicioVenta
            // 
            this.LblInicioVenta.AutoSize = true;
            this.LblInicioVenta.Location = new System.Drawing.Point(21, 218);
            this.LblInicioVenta.Name = "LblInicioVenta";
            this.LblInicioVenta.Size = new System.Drawing.Size(128, 15);
            this.LblInicioVenta.TabIndex = 4;
            this.LblInicioVenta.Text = "Fecha de Inicio o Venta";
            // 
            // LblFechaDeFin
            // 
            this.LblFechaDeFin.AutoSize = true;
            this.LblFechaDeFin.Location = new System.Drawing.Point(21, 258);
            this.LblFechaDeFin.Name = "LblFechaDeFin";
            this.LblFechaDeFin.Size = new System.Drawing.Size(73, 15);
            this.LblFechaDeFin.TabIndex = 5;
            this.LblFechaDeFin.Text = "Fecha de Fin";
            // 
            // LblPrecioAlquier
            // 
            this.LblPrecioAlquier.AutoSize = true;
            this.LblPrecioAlquier.Location = new System.Drawing.Point(21, 298);
            this.LblPrecioAlquier.Name = "LblPrecioAlquier";
            this.LblPrecioAlquier.Size = new System.Drawing.Size(100, 15);
            this.LblPrecioAlquier.TabIndex = 6;
            this.LblPrecioAlquier.Text = "Precio de Alquiler";
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Location = new System.Drawing.Point(21, 336);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(88, 15);
            this.LblPrecioVenta.TabIndex = 7;
            this.LblPrecioVenta.Text = "Precio de Venta";
            // 
            // CboPropiedad
            // 
            this.CboPropiedad.FormattingEnabled = true;
            this.CboPropiedad.Location = new System.Drawing.Point(174, 122);
            this.CboPropiedad.Name = "CboPropiedad";
            this.CboPropiedad.Size = new System.Drawing.Size(155, 23);
            this.CboPropiedad.TabIndex = 8;
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(174, 173);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(155, 23);
            this.CboCliente.TabIndex = 9;
            // 
            // DtpFechaInicioOVenta
            // 
            this.DtpFechaInicioOVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicioOVenta.Location = new System.Drawing.Point(174, 218);
            this.DtpFechaInicioOVenta.Name = "DtpFechaInicioOVenta";
            this.DtpFechaInicioOVenta.Size = new System.Drawing.Size(155, 23);
            this.DtpFechaInicioOVenta.TabIndex = 10;
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(172, 258);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(155, 23);
            this.DtpFechaFin.TabIndex = 11;
            // 
            // NumUpDownAlquiler
            // 
            this.NumUpDownAlquiler.Location = new System.Drawing.Point(172, 298);
            this.NumUpDownAlquiler.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.NumUpDownAlquiler.Name = "NumUpDownAlquiler";
            this.NumUpDownAlquiler.Size = new System.Drawing.Size(155, 23);
            this.NumUpDownAlquiler.TabIndex = 12;
            // 
            // NumUpDownVenta
            // 
            this.NumUpDownVenta.Location = new System.Drawing.Point(172, 336);
            this.NumUpDownVenta.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.NumUpDownVenta.Name = "NumUpDownVenta";
            this.NumUpDownVenta.Size = new System.Drawing.Size(155, 23);
            this.NumUpDownVenta.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(597, 309);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 42);
            this.BtnCancelar.TabIndex = 31;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(472, 309);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 42);
            this.BtnGuardar.TabIndex = 30;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblTituloPrincipal
            // 
            this.LblTituloPrincipal.AutoSize = true;
            this.LblTituloPrincipal.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTituloPrincipal.Location = new System.Drawing.Point(417, 43);
            this.LblTituloPrincipal.Name = "LblTituloPrincipal";
            this.LblTituloPrincipal.Size = new System.Drawing.Size(348, 59);
            this.LblTituloPrincipal.TabIndex = 29;
            this.LblTituloPrincipal.Text = "Nueva Operacion";
            // 
            // FrmCompraAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTituloPrincipal);
            this.Controls.Add(this.NumUpDownVenta);
            this.Controls.Add(this.NumUpDownAlquiler);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.DtpFechaInicioOVenta);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.CboPropiedad);
            this.Controls.Add(this.LblPrecioVenta);
            this.Controls.Add(this.LblPrecioAlquier);
            this.Controls.Add(this.LblFechaDeFin);
            this.Controls.Add(this.LblInicioVenta);
            this.Controls.Add(this.LblSeleccionCliente);
            this.Controls.Add(this.LblSeleccionPropiedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboAlquilerVenta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompraAlquiler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Alquileres o Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboAlquilerVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSeleccionPropiedad;
        private System.Windows.Forms.Label LblSeleccionCliente;
        private System.Windows.Forms.Label LblInicioVenta;
        private System.Windows.Forms.Label LblFechaDeFin;
        private System.Windows.Forms.Label LblPrecioAlquier;
        private System.Windows.Forms.Label LblPrecioVenta;
        private System.Windows.Forms.ComboBox CboPropiedad;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.DateTimePicker DtpFechaInicioOVenta;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.NumericUpDown NumUpDownAlquiler;
        private System.Windows.Forms.NumericUpDown NumUpDownVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblTituloPrincipal;
    }
}
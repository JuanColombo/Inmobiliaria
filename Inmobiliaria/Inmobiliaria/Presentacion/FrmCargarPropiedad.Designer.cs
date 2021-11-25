
namespace Inmobiliaria.Presentacion
{
    partial class FrmCargarPropiedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarPropiedad));
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.NumUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.LblDisponibilidad = new System.Windows.Forms.Label();
            this.ChkDisponible = new System.Windows.Forms.CheckBox();
            this.LblPropietario = new System.Windows.Forms.Label();
            this.CboPropietario = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCapturarFoto = new System.Windows.Forms.Button();
            this.BtnIniciarDetenerCamara = new System.Windows.Forms.Button();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(121, 131);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(276, 23);
            this.TxtNombre.TabIndex = 13;
            // 
            // LblTituloPrincipal
            // 
            this.LblTituloPrincipal.AutoSize = true;
            this.LblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTituloPrincipal.Location = new System.Drawing.Point(242, 9);
            this.LblTituloPrincipal.Name = "LblTituloPrincipal";
            this.LblTituloPrincipal.Size = new System.Drawing.Size(327, 46);
            this.LblTituloPrincipal.TabIndex = 15;
            this.LblTituloPrincipal.Text = "Nueva Propiedad";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(52, 134);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 15);
            this.LblNombre.TabIndex = 14;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Location = new System.Drawing.Point(121, 183);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(276, 23);
            this.TxtUbicacion.TabIndex = 16;
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Location = new System.Drawing.Point(43, 186);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(63, 15);
            this.LblUbicacion.TabIndex = 17;
            this.LblUbicacion.Text = "Ubicacion:";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(22, 238);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(84, 15);
            this.LblValor.TabIndex = 19;
            this.LblValor.Text = "Valor (en AR$):";
            // 
            // NumUpDownValor
            // 
            this.NumUpDownValor.Location = new System.Drawing.Point(121, 236);
            this.NumUpDownValor.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.NumUpDownValor.Name = "NumUpDownValor";
            this.NumUpDownValor.Size = new System.Drawing.Size(276, 23);
            this.NumUpDownValor.TabIndex = 20;
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Location = new System.Drawing.Point(20, 291);
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(86, 15);
            this.LblDisponibilidad.TabIndex = 21;
            this.LblDisponibilidad.Text = "Disponibilidad:";
            // 
            // ChkDisponible
            // 
            this.ChkDisponible.AutoSize = true;
            this.ChkDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkDisponible.Location = new System.Drawing.Point(121, 283);
            this.ChkDisponible.Name = "ChkDisponible";
            this.ChkDisponible.Size = new System.Drawing.Size(118, 28);
            this.ChkDisponible.TabIndex = 22;
            this.ChkDisponible.Text = "Disponible";
            this.ChkDisponible.UseVisualStyleBackColor = true;
            // 
            // LblPropietario
            // 
            this.LblPropietario.AutoSize = true;
            this.LblPropietario.Location = new System.Drawing.Point(38, 343);
            this.LblPropietario.Name = "LblPropietario";
            this.LblPropietario.Size = new System.Drawing.Size(68, 15);
            this.LblPropietario.TabIndex = 23;
            this.LblPropietario.Text = "Propietario:";
            // 
            // CboPropietario
            // 
            this.CboPropietario.FormattingEnabled = true;
            this.CboPropietario.Location = new System.Drawing.Point(121, 340);
            this.CboPropietario.Name = "CboPropietario";
            this.CboPropietario.Size = new System.Drawing.Size(276, 23);
            this.CboPropietario.TabIndex = 24;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(688, 396);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 42);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(563, 396);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 42);
            this.BtnGuardar.TabIndex = 25;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(594, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCapturarFoto
            // 
            this.BtnCapturarFoto.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCapturarFoto.Location = new System.Drawing.Point(717, 274);
            this.BtnCapturarFoto.Name = "BtnCapturarFoto";
            this.BtnCapturarFoto.Size = new System.Drawing.Size(92, 32);
            this.BtnCapturarFoto.TabIndex = 32;
            this.BtnCapturarFoto.Text = "Borrar foto";
            this.BtnCapturarFoto.UseVisualStyleBackColor = true;
            this.BtnCapturarFoto.Click += new System.EventHandler(this.BtnCapturarFoto_Click_1);
            // 
            // BtnIniciarDetenerCamara
            // 
            this.BtnIniciarDetenerCamara.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnIniciarDetenerCamara.Location = new System.Drawing.Point(619, 274);
            this.BtnIniciarDetenerCamara.Name = "BtnIniciarDetenerCamara";
            this.BtnIniciarDetenerCamara.Size = new System.Drawing.Size(92, 32);
            this.BtnIniciarDetenerCamara.TabIndex = 31;
            this.BtnIniciarDetenerCamara.Text = "Iniciar cámara";
            this.BtnIniciarDetenerCamara.UseVisualStyleBackColor = true;
            this.BtnIniciarDetenerCamara.Click += new System.EventHandler(this.BtnIniciarDetenerCamara_Click);
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExaminar.Location = new System.Drawing.Point(538, 274);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(75, 32);
            this.BtnExaminar.TabIndex = 30;
            this.BtnExaminar.Text = "Examinar";
            this.BtnExaminar.UseVisualStyleBackColor = true;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // PbxImagen
            // 
            this.PbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxImagen.Location = new System.Drawing.Point(563, 85);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(199, 183);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImagen.TabIndex = 29;
            this.PbxImagen.TabStop = false;
            // 
            // FrmCargarPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.BtnCapturarFoto);
            this.Controls.Add(this.BtnIniciarDetenerCamara);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboPropietario);
            this.Controls.Add(this.LblPropietario);
            this.Controls.Add(this.ChkDisponible);
            this.Controls.Add(this.LblDisponibilidad);
            this.Controls.Add(this.NumUpDownValor);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.TxtUbicacion);
            this.Controls.Add(this.LblUbicacion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblTituloPrincipal);
            this.Controls.Add(this.LblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarPropiedad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Propiedad";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblTituloPrincipal;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.NumericUpDown NumUpDownValor;
        private System.Windows.Forms.Label LblDisponibilidad;
        private System.Windows.Forms.CheckBox ChkDisponible;
        private System.Windows.Forms.Label LblPropietario;
        private System.Windows.Forms.ComboBox CboPropietario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCapturarFoto;
        private System.Windows.Forms.Button BtnIniciarDetenerCamara;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.PictureBox PbxImagen;
    }
}
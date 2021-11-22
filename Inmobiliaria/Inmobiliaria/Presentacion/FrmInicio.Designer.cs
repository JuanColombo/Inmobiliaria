
namespace Inmobiliaria.Presentacion
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            this.PbInicio = new System.Windows.Forms.ProgressBar();
            this.timerInicio = new System.Windows.Forms.Timer(this.components);
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PbInicio
            // 
            this.PbInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PbInicio.ForeColor = System.Drawing.Color.Transparent;
            this.PbInicio.Location = new System.Drawing.Point(12, 303);
            this.PbInicio.Name = "PbInicio";
            this.PbInicio.Size = new System.Drawing.Size(461, 24);
            this.PbInicio.TabIndex = 0;
            // 
            // timerInicio
            // 
            this.timerInicio.Enabled = true;
            this.timerInicio.Interval = 30;
            this.timerInicio.Tick += new System.EventHandler(this.timerInicio_Tick);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentaje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentaje.Location = new System.Drawing.Point(475, 305);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(25, 19);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "%";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Inmobiliaria.Properties.Resources.inmobiliaria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 339);
            this.ControlBox = false;
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.PbInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciando Sistema";
            this.Activated += new System.EventHandler(this.FrmInicio_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PbInicio;
        private System.Windows.Forms.Timer timerInicio;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}
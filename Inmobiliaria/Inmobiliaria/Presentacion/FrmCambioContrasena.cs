using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inmobiliaria.Models;
using Inmobiliaria.Core;

namespace Inmobiliaria.Presentacion
{
    public partial class FrmCambioContrasena : Form
    {
        public int? IdActual { get; set; }
        Usuario usuario = new Usuario();
        public FrmCambioContrasena(int idSeleccionado)
        {
            InitializeComponent();
            
            if (idSeleccionado != 0)
            {
                IdActual = idSeleccionado;
                CargarCboUsuarioActual();
            }
        }

        private void CargarCboUsuarioActual()
        {
            using (var db = new InmobiliariaContext())
            {
                usuario = db.Usuarios.Find(IdActual);
                lblUsuarioActivo.Text = (usuario.User).ToUpper();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarContraseña_Click(object sender, EventArgs e)
        {
            CompararContraseñaActualConBBDD();
        }

        private void CompararContraseñaActualConBBDD()
        {
            if (HelperInmobiliaria.ObtenerSha256Hash(txtContraseñaActual.Text) == usuario.Password)
            {
                if (txtContraseñaNueva.Text == txtConfirmacionContraseña.Text)
                {
                    using (var db = new InmobiliariaContext())
                    {
                        usuario.Password = HelperInmobiliaria.ObtenerSha256Hash(txtContraseñaNueva.Text);
                        db.Entry(usuario).State = EntityState.Modified;
                        MessageBox.Show("Contraseña modificada con exito");
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else 
                { 
                    MessageBox.Show("Las Contraseñas no coinciden");
                    VaciarCampos();
                }
                
            }
            else
            {
                MessageBox.Show("Contraseña Actual Incorrecta");
                VaciarCampos();
            }

        }
        private void VaciarCampos()
        {
            txtContraseñaActual.Text = "";
            txtContraseñaNueva.Text = "";
            txtConfirmacionContraseña.Text = "";
        }
    }
}

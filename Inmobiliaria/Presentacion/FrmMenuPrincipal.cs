using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Presentacion;

namespace Inmobiliaria
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

     
        // CARGA DE FORMULARIOS A PARTIR DE BOTONES Y MENUS
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var frmCargarCliente = new FrmCargarCliente();
            frmCargarCliente.ShowDialog();


        }

        private void BtnNuevoPropietario_Click(object sender, EventArgs e)
        {
            var frmCargarPropietario = new FrmCargarPropietario();
            frmCargarPropietario.ShowDialog();
        }

        private void BtnNuevaPropiedad_Click(object sender, EventArgs e)
        {
            var frmCargarPropiedad = new FrmCargarPropiedad();
            frmCargarPropiedad.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que deseas salir ?", "Cerrar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el tutor a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SubMnuClientes_Click(object sender, EventArgs e)
        {
            var frmVerEditarCliente = new FrmVerEditarClientes();
            frmVerEditarCliente.ShowDialog();
        }

        private void SubMnuPropietarios_Click(object sender, EventArgs e)
        {
            var frmVerEditarPropietario = new FrmVerEditarPropietario();
            frmVerEditarPropietario.ShowDialog();
        }

        private void SunMnuPropiedades_Click(object sender, EventArgs e)
        {
            var frmVerEditarPropiedad = new FrmVerEditarPropiedad();
            frmVerEditarPropiedad.ShowDialog();
        }

        private void SubMnuListadoClientes_Click(object sender, EventArgs e)
        {
            var frmListadoClientes = new FrmListadoClientes();
            frmListadoClientes.ShowDialog();
        }

        private void SubMnuListadoPropietarios_Click(object sender, EventArgs e)
        {
            var frmListadoPropietarios = new FrmListadoPropietarios();
            frmListadoPropietarios.ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frmVerEditarCliente = new FrmVerEditarClientes();
            frmVerEditarCliente.ShowDialog();
        }

        private void BtnPropiedades_Click(object sender, EventArgs e)
        {
            var frmVerEditarPropiedad = new FrmVerEditarPropiedad();
            frmVerEditarPropiedad.ShowDialog();
        }

        private void BtnPropietarios_Click(object sender, EventArgs e)
        {
            var frmVerEditarPropietario = new FrmVerEditarPropietario();
            frmVerEditarPropietario.ShowDialog();
        }

        private void BtnAlquilerVenta_Click(object sender, EventArgs e)
        {
            var frmCompraAlquier = new FrmCompraAlquiler();
            frmCompraAlquier.ShowDialog();
        }
    }
}

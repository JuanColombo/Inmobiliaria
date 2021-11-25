using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.AdminData;
using Inmobiliaria.Models;
using Inmobiliaria.Presentacion;
using Inmobiliaria.Core;

namespace Inmobiliaria
{
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario Usuario;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BackgroundImage = HelperInmobiliaria.RecuperarImagenDeArchivoDeRecursos("fondoSistema"); ;
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
                Application.Exit();
            }
        }

        private void SubMnuClientes_Click(object sender, EventArgs e)
        {
            //var frmVerEditarCliente = new FrmVerEditarClientes();
            //frmVerEditarCliente.ShowDialog();
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente());
            frmCargarClientes.ShowDialog();
        }

        private void SubMnuPropietarios_Click(object sender, EventArgs e)
        {
            // var frmVerEditarPropietario = new FrmVerEditarPropietario();
            //frmVerEditarPropietario.ShowDialog();
            var frmCargarPropietario = new FrmBase(new DbAdminPropietarios(), new FrmCargarPropietario());
            frmCargarPropietario.ShowDialog();

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
            //var frmVerEditarCliente = new FrmVerEditarClientes();
            //frmVerEditarCliente.ShowDialog();
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente());
            frmCargarClientes.ShowDialog();

        }

        private void BtnPropiedades_Click(object sender, EventArgs e)
        {
            var frmVerEditarPropiedad = new FrmVerEditarPropiedad();
            frmVerEditarPropiedad.ShowDialog();
        }

        private void BtnPropietarios_Click(object sender, EventArgs e)
        {
            //var frmVerEditarPropietario = new FrmVerEditarPropietario();
            //frmVerEditarPropietario.ShowDialog();
            var frmCargarPropietario = new FrmBase(new DbAdminPropietarios(), new FrmCargarPropietario());
            frmCargarPropietario.ShowDialog();
        }

        private void BtnAlquilerVenta_Click(object sender, EventArgs e)
        {
            var frmCompraAlquier = new FrmCompraAlquiler();
            frmCompraAlquier.ShowDialog();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                //si no hay nadie logeado, entonces mostramos el formulario de Login
                var frmLogin = new FrmLogin(this);
                frmLogin.ShowDialog();
                if (Usuario != null)
                {
                    //dependiendo el tipo de usuario, habilitamos los distintos menues para que tengan acceso
                    MnuUsuario.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador ? true : false;
                    MnuCambioContraseña.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador ? true : false;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btnPropietariosyPropiedades_Click(object sender, EventArgs e)
        {
            var frmPropietariosYPropiedades = new FrmPropietariosYPropiedades();
            frmPropietariosYPropiedades.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmGestionUsuarios = new FrmGestionUsuario();
            frmGestionUsuarios.ShowDialog();
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCambioContraseña = new FrmCambioContrasena(FrmMenuPrincipal.Usuario.Id);
            frmCambioContraseña.ShowDialog();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmParametros = new FrmParametros(this);
            frmParametros.ShowDialog();
        }
    }
}

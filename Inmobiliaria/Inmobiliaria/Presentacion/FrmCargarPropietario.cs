
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inmobiliaria.AdminData;
using Inmobiliaria.Interfaces;
using Inmobiliaria.Models;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Presentacion
{
    public partial class FrmCargarPropietario : Form, IFormBase
    {
        DbAdminPropietarios dbAdmin = new DbAdminPropietarios();
        public int? IdEditar { get; set; }
        Propietario propietario = new Propietario();
        public FrmCargarPropietario()
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboIva();
            CargarComboEstadoCivil();

        }
        public FrmCargarPropietario(int idSeleccionado)
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboIva();
            CargarComboEstadoCivil();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelPropietario();
            }

        }

        private void CargarDatosDelPropietario()
        {
            using (var db = new InmobiliariaContext())
            {
                propietario = db.Propietario.Find(IdEditar);
                TxtNombre.Text = propietario.Nombre;
                TxtApellido.Text = propietario.Apellido;
                TxtDomicilio.Text = propietario.Domicilio;
                NumUpDownDni.Value = propietario.Dni;
                NumUpDownCuil.Value = (decimal)propietario.Cuil;
                NumUpDownCuit.Value = (decimal)propietario.Cuit;
                DtpFechaNacimiento.Value = propietario.FechaNacimiento;
                NumUpDownTelefono.Value = (decimal)propietario.Telefono;
                CboSexo.SelectedItem = propietario.Sexo;
                TxtEmail.Text = propietario.Email;
                CboEstadoCivil.SelectedItem = propietario.EstadoCivil;
                TxtLocalidad.Text = propietario.Localidad;
                CboCondicionIva.SelectedItem = propietario.CondicionIva;
            }
        }

        private void CargarComboEstadoCivil()
        {
            CboEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivilEnum));
        }

        private void CargarComboIva()
        {
            CboCondicionIva.DataSource = Enum.GetValues(typeof(CondicionIvaEnum));
        }

        private void CargarComboSexo()
        {
            CboSexo.DataSource = Enum.GetValues(typeof(SexoEnum));
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CAMINO POR SI ES UN NUEVO Calendario

            if (propietario.Id == 0)

            {
                //length nos cuenta la cantidad de caracteres que hay en el string
                if (TxtNombre.Text.Length == 0)
                    this.Close();

                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
            else  //CAMINO SI ES MODIFICANDO A UN Calendario EXISTENTE
            {
                if (CompararDatosFormularioConLosDeBBDD())
                    this.Close();
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new InmobiliariaContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                propietario.Nombre = TxtNombre.Text;
                propietario.Apellido = TxtApellido.Text;
                propietario.Domicilio = TxtDomicilio.Text;
                propietario.Dni = (int)NumUpDownDni.Value;
                propietario.Cuil = (double)NumUpDownCuil.Value;
                propietario.Cuit = (double)NumUpDownCuit.Value;
                propietario.FechaNacimiento = DtpFechaNacimiento.Value.Date;
                propietario.Telefono = (double)NumUpDownTelefono.Value;
                propietario.Sexo = (SexoEnum)CboSexo.SelectedValue;
                propietario.Email = TxtEmail.Text;
                propietario.EstadoCivil = (EstadoCivilEnum)CboEstadoCivil.SelectedValue;
                propietario.Localidad = TxtLocalidad.Text;
                propietario.CondicionIva = (CondicionIvaEnum)CboCondicionIva.SelectedValue;

                //si el id del Cliente a editar es nulo agregamos un Cliente Nuevo a la tabla
                if (IdEditar == null)
                    // agregamos el objeto Clientes a la Base De datos
                    db.Propietario.Add(propietario);
                else //configuramos el almacenamiento de la modificacion si el id del Cliente es distinto de nulo
                {
                    db.Entry(propietario).State = EntityState.Modified;
                }
                db.SaveChanges();

                if (IdEditar == null)
                    MessageBox.Show("Propietario " + propietario.Apellido + " " + propietario.Nombre + " cargado con exito");
                else
                    MessageBox.Show("Propietario " + propietario.Apellido + " " + propietario.Nombre + "  modificado con exito");
                this.Close();

            }
        }
        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea salir del formulario sin guardar los datos? ", "Datos sin Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
        }
        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (propietario.Nombre == TxtNombre.Text && propietario.Sexo == (SexoEnum)CboSexo.SelectedValue && propietario.CondicionIva == (CondicionIvaEnum)CboCondicionIva.SelectedValue);
        }

        public void CargarDatosEnPantalla()
        {
            propietario = (Propietario)dbAdmin.Obtener(IdEditar);
            TxtNombre.Text = propietario.Nombre;
            TxtApellido.Text = propietario.Apellido;
            TxtDomicilio.Text = propietario.Domicilio;
            NumUpDownDni.Value = propietario.Dni;
            NumUpDownCuil.Value = (decimal)propietario.Cuil;
            NumUpDownCuit.Value = (decimal)propietario.Cuit;
            DtpFechaNacimiento.Value = propietario.FechaNacimiento;
            NumUpDownTelefono.Value = (decimal)propietario.Telefono;
            CboSexo.SelectedItem = propietario.Sexo;
            TxtEmail.Text = propietario.Email;
            CboEstadoCivil.SelectedItem = propietario.EstadoCivil;
            TxtLocalidad.Text = propietario.Localidad;
            CboCondicionIva.SelectedItem = propietario.CondicionIva;
        }

        public void LimpiarDatosDeLaPantalla()
        {
            propietario = new Propietario();
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDomicilio.Text = "";
            NumUpDownDni.Value = 0;
            NumUpDownCuil.Value = 0;
            NumUpDownCuit.Value = 0;
            DtpFechaNacimiento.Value = DateTime.Now;
            NumUpDownTelefono.Value = 0;
            CboSexo.SelectedItem = 0;
            TxtEmail.Text = "";
            CboEstadoCivil.SelectedItem = 0;
            TxtLocalidad.Text = "";
            CboCondicionIva.SelectedItem = 0;
        }
    }
}

using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inmobiliaria.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Inmobiliaria.Interfaces;
using Inmobiliaria.AdminData;

namespace Inmobiliaria.Presentacion
{
    public partial class FrmCargarCliente : Form, IFormBase
    {
        DbAdminClientes dbAdmin = new DbAdminClientes();
        public int? IdEditar { get; set; }
        Cliente cliente = new Cliente();
        
        public FrmCargarCliente()
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboIva();
            CargarComboEstadoCivil();
            
        }
        public FrmCargarCliente(int idSeleccionado)
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboIva();
            CargarComboEstadoCivil();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelCliente();
            }

        }

        private void CargarDatosDelCliente()
        {
            using (var db = new InmobiliariaContext())
            {
                cliente = db.Cliente.Find(IdEditar);
                TxtNombre.Text = cliente.Nombre;
                TxtApellido.Text = cliente.Apellido;
                TxtDomicilio.Text = cliente.Domicilio;
                NumUpDownDni.Value = cliente.Dni;
                NumUpDownCuil.Value = (decimal)cliente.Cuil;
                NumUpDownCuit.Value = (decimal)cliente.Cuit;
                DtpFechaNacimiento.Value = cliente.FechaNacimiento;
                NumUpDownTelefono.Value = (decimal)cliente.Telefono;
                CboSexo.SelectedItem = cliente.Sexo;
                TxtEmail.Text = cliente.Email;
                CboEstadoCivil.SelectedItem = cliente.EstadoCivil;
                TxtLocalidad.Text = cliente.Localidad;
                CboCondicionIva.SelectedItem = cliente.CondicionIva;
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
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           
            using (var db = new InmobiliariaContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                cliente.Nombre = TxtNombre.Text;
                cliente.Apellido = TxtApellido.Text;
                cliente.Domicilio = TxtDomicilio.Text;
                cliente.Dni = (int)NumUpDownDni.Value;
                cliente.Cuil = (double)NumUpDownCuil.Value;
                cliente.Cuit = (double)NumUpDownCuit.Value;
                cliente.FechaNacimiento = DtpFechaNacimiento.Value.Date;
                cliente.Telefono = (double)NumUpDownTelefono.Value;
                cliente.Sexo = (SexoEnum)CboSexo.SelectedValue;
                cliente.Email = TxtEmail.Text;
                cliente.EstadoCivil = (EstadoCivilEnum)CboEstadoCivil.SelectedValue;
                cliente.Localidad = TxtLocalidad.Text;
                cliente.CondicionIva = (CondicionIvaEnum)CboCondicionIva.SelectedValue;

                //si el id del Cliente a editar es nulo agregamos un Cliente Nuevo a la tabla
                if (IdEditar == null)
                    // agregamos el objeto Clientes a la Base De datos
                    db.Cliente.Add(cliente);
                else //configuramos el almacenamiento de la modificacion si el id del Cliente es distinto de nulo
                {
                    db.Entry(cliente).State = EntityState.Modified;
                }
                db.SaveChanges();

                if (IdEditar == null)
                      MessageBox.Show("Cliente " + cliente.Apellido + " " + cliente.Nombre + " cargado con exito");
                else
                      MessageBox.Show("Cliente " + cliente.Apellido + " " + cliente.Nombre + "  modificado con exito");
                this.Close();

            }
        }

        public void CargarDatosEnPantalla()
        {
            cliente = (Cliente)dbAdmin.Obtener(IdEditar);
            TxtNombre.Text = cliente.Nombre;
            TxtApellido.Text = cliente.Apellido;
            TxtDomicilio.Text = cliente.Domicilio;
            NumUpDownDni.Value = cliente.Dni;
            NumUpDownCuil.Value = (decimal)cliente.Cuil;
            NumUpDownCuit.Value = (decimal)cliente.Cuit;
            DtpFechaNacimiento.Value = cliente.FechaNacimiento;
            NumUpDownTelefono.Value = (decimal)cliente.Telefono;
            CboSexo.SelectedItem = cliente.Sexo;
            TxtEmail.Text = cliente.Email;
            CboEstadoCivil.SelectedItem = cliente.EstadoCivil;
            TxtLocalidad.Text = cliente.Localidad;
            CboCondicionIva.SelectedItem = cliente.CondicionIva;
        }

        public void LimpiarDatosDeLaPantalla()
        {
            cliente = new Cliente();
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

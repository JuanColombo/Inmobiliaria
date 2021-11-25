using Inmobiliaria.AdminData;
using Inmobiliaria.Interfaces;
using Inmobiliaria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion
{
    public partial class FrmVerEditarPropietario : Form
    {
        DbAdminPropietarios dbAdmin = new DbAdminPropietarios();
        public FrmVerEditarPropietario()
        {
            InitializeComponent();
            ActualizarGrilla();

        }

        private void ActualizarGrilla()
        {

            using (var db = new InmobiliariaContext())
            {
                //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                var propietariosAListar = from propietario in db.Propietario
                                          select new
                                          {
                                              Id = propietario.Id,
                                              Nombre = propietario.Apellido + " " + propietario.Nombre,
                                              DNI = propietario.Dni,
                                              Telefono = propietario.Telefono,
                                              Domicilio = propietario.Domicilio,
                                              Localidad = propietario.Localidad
                                          };
                //cargamos la grilla con la coleccion creada

                Grid.DataSource = propietariosAListar.ToList();
            }

        }

        private void ActualizarGrilla(string textoABuscar)
        {


            using (var db = new InmobiliariaContext())
            {
                //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                var propietariosAListar = from propietario in db.Propietario
                                          select new
                                          {
                                              Id = propietario.Id,
                                              Nombre = propietario.Apellido + " " + propietario.Nombre,
                                              DNI = propietario.Dni,
                                              Telefono = propietario.Telefono,
                                              Domicilio = propietario.Domicilio,
                                              Localidad = propietario.Localidad
                                          };
                //cargamos la grilla con la coleccion creada
                Grid.DataSource = propietariosAListar.Where(t => t.Nombre.Contains(textoABuscar) || t.DNI.ToString().Contains(textoABuscar)).ToList();

            }

        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmCargarPropietario = new FrmCargarPropietario();
            frmCargarPropietario.ShowDialog();
            ActualizarGrilla();
            Grid.CurrentCell = Grid.Rows[Grid.RowCount - 1].Cells[0];
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber el id del Cliente que tenemos seleccionado
            var idSeleccionado = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = Grid.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  Cliente
            var frmCargarPropietario = new FrmCargarPropietario(idSeleccionado);
            frmCargarPropietario.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            Grid.CurrentCell = Grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del Cliente seleccionado en la grilla
            //guardamos en la variable EL ID del Cliente

            var idPropietarioSeleccionado = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());

            //guardamos en la variable el nombre del Cliente
            var NombrePropietarioSeleccionado = Grid.CurrentRow.Cells[1].Value.ToString();

            // preguntar si realmente desea eliminar al Cliente [nombreClienteSeleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar al cliente {NombrePropietarioSeleccionado}?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el cliente a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                using (var db = new InmobiliariaContext())
                {
                    var propietario = db.Propietario.Find(idPropietarioSeleccionado);
                    db.Propietario.Remove(propietario);
                    db.SaveChanges();
                }
                ActualizarGrilla();
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrilla(TxtBusqueda.Text);
        }

    }
}

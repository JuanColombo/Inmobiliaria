using Inmobiliaria.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion
{
    public partial class FrmVerEditarPropiedad : Form
    {
        public FrmVerEditarPropiedad()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            using (var db = new InmobiliariaContext())
            {
                //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                var propiedadesAListar = from propiedades in db.Propiedades
                                      select new
                                      {
                                          Id = propiedades.Id,
                                          Nombre = propiedades.Nombre,
                                          Ubicacion = propiedades.Ubicacion,
                                          Valor = propiedades.Valor,
                                          Disponibilidad = propiedades.Disponibilidad,
                                          Propietario = propiedades.Propietario.Apellido + " "+ propiedades.Propietario.Nombre

                                      };
                //cargamos la grilla con la coleccion creada
                Grid.DataSource = propiedadesAListar.ToList();

            }
        }

        private void ActualizarGrilla(string textoABuscar)
        {
            using (var db = new InmobiliariaContext())
            {
                //creamos una coleccion para seleccionar los datos que queremos mostrar en la grilla 
                var propiedadesAListar = from propiedades in db.Propiedades
                                         select new
                                         {
                                             Id = propiedades.Id,
                                             Nombre = propiedades.Nombre,
                                             Ubicacion = propiedades.Ubicacion,
                                             Valor = propiedades.Valor,
                                             Disponibilidad = propiedades.Disponibilidad,
                                             Propietario = propiedades.Propietario.Apellido + " " + propiedades.Propietario.Nombre

                                         };
                //cargamos la grilla con la coleccion creada
                Grid.DataSource = propiedadesAListar.Where(t => t.Nombre.Contains(textoABuscar)|| t.Ubicacion.Contains(textoABuscar)).ToList();

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarPropiedad = new FrmCargarPropiedad();
            frmNuevoEditarPropiedad.ShowDialog();
            ActualizarGrilla();
            Grid.CurrentCell = Grid.Rows[Grid.RowCount - 1].Cells[0];
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber el id de la Propiedad que tenemos seleccionada
            var idSeleccionado = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = Grid.CurrentRow.Index;

            //abrimos el formulario para la edicion de una Propiedad
            var frmCargarPropiedad = new FrmCargarPropiedad(idSeleccionado);
            frmCargarPropiedad.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            Grid.CurrentCell = Grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre de la propiedad seleccionada en la grilla
            //guardamos en la variable EL ID de la Propiedad

            var idPropiedadSeleccionada = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());

            //guardamos en la variable el nombre de la Propiedad
            var nombrePropiedadSeleccionada = Grid.CurrentRow.Cells[1].Value.ToString();

            // preguntar si realmente desea eliminar a la Propiedad [nombrePropiedadSeleccionada]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar la propiedad  {nombrePropiedadSeleccionada}?", "Eliminar Propiedad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos la propiedad a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                using (var db = new InmobiliariaContext())
                {
                    var propiedades = db.Propiedades.Find(idPropiedadSeleccionada);
                    db.Propiedades.Remove(propiedades);
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

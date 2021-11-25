
using Inmobiliaria.AdminData;
using Inmobiliaria.Models;
using Inmobiliaria.Presentacion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace Inmobiliaria.Presentacion
{
    public partial class FrmPropietariosYPropiedades : Form
    {
        DbAdminPropietarios dbAdminPropietarios = new DbAdminPropietarios();
        Propietario propietario { get; set; }

        //contructor (metodo que no devuelve valores que se llama igual que la clase
        public FrmPropietariosYPropiedades()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

         private void ActualizarGrilla()
        {
            gridPropietarios.DataSource = dbAdminPropietarios.ObtenerTodos();
            gridPropietarios.OcultarColumnas();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmCargarPropietario = new FrmCargarPropietario();
            frmCargarPropietario.ShowDialog();
            //actualizamos la grilla
            ActualizarGrilla();
            //seleccionamos el registro editado
            gridPropietarios.CurrentCell = gridPropietarios.Rows[gridPropietarios.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de tutor tenemos seleccionado
            var idPropietarioSeleccionado = gridPropietarios.ObtenerIdSeleccionado();
            var filaAEditar = gridPropietarios.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  tutor
            var FrmCargarPropietario = new FrmCargarPropietario(idPropietarioSeleccionado);
            FrmCargarPropietario.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            gridPropietarios.CurrentCell = gridPropietarios.Rows[filaAEditar].Cells[0];        

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del tutor seleccionado en la grilla
            var idPropietarioSeleccionado = gridPropietarios.ObtenerIdSeleccionado();

            //guardamos en la variable el nombre y el apellido del tutor seleccionado
            var nombrePropietarioSeleccionado = gridPropietarios.CurrentRow.Cells[1].Value.ToString() +" "+ gridPropietarios.CurrentRow.Cells[2].Value.ToString();

            // preguntar si realmente desea eliminar al tutor [nombre_tutor_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar a {nombrePropietarioSeleccionado}?","Eliminar Tutor", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el tutor a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes)
            {
                dbAdminPropietarios.Eliminar(idPropietarioSeleccionado);
                ActualizarGrilla();   
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gridPropietarios.DataSource = dbAdminPropietarios.ObtenerTodos(TxtBusqueda.Text);
        }



        private void ActualizarGrillaPropiedades()
        {
            if (gridPropietarios.CurrentRow != null)
            {
                var idPropietarioSeleccionado = gridPropietarios.ObtenerIdSeleccionado();
                if (idPropietarioSeleccionado > 0)
                    {
                        using var db = new InmobiliariaContext();
                        propietario = (Propietario)db.Propietario.Where(t => t.Id == idPropietarioSeleccionado).Include(p => p.Propiedades).FirstOrDefault();
                        var propiedadesAListar = from propiedades in propietario.Propiedades
                                               select new
                                               {
                                                   id = propiedades.Id,
                                                   nombre = propiedades.Nombre + " ",
                                                   Ubicacion = propiedades.Ubicacion,
                                                   Valor = propiedades.Valor
                                               };

                        gridPropiedades.DataSource = propiedadesAListar.ToList();
                    }
            }
        }

      
        private void gridPropietarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarGrillaPropiedades();
        }

        private void BtnAgregarPropiedad_Click(object sender, EventArgs e)
        {   
            var frmCargarPropiedad = new FrmCargarPropiedad(propietario);
            frmCargarPropiedad.ShowDialog();
            ActualizarGrillaPropiedades();
            gridPropiedades.CurrentCell = gridPropiedades.Rows[gridPropiedades.RowCount - 1].Cells[0];
        }

        private void BtnEditarPropiedad_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de tutor tenemos seleccionado
            var idPropiedadSeleccionada = int.Parse(gridPropiedades.CurrentRow.Cells[0].Value.ToString());
            var filaAEditar = gridPropiedades.CurrentRow.Index;

            //abrimos el formulario para la edicion de un  tutor
            var frmCargarPropiedad = new FrmCargarPropiedad(propietario, idPropiedadSeleccionada);
            frmCargarPropiedad.ShowDialog();

            //actualizamos la grilla
            ActualizarGrillaPropiedades();

            //seleccionamos el registro editado
            gridPropietarios.CurrentCell = gridPropietarios.Rows[filaAEditar].Cells[0];
        }
    }
}

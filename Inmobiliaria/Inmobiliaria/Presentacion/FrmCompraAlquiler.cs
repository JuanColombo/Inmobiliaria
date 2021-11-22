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

namespace Inmobiliaria.Presentacion
{
    public partial class FrmCompraAlquiler : Form
    {
        DetalleCompraAlquiler detallecompraalquier = new DetalleCompraAlquiler();
        public FrmCompraAlquiler()
        {
            InitializeComponent();
            CargarComboTipoOperacion();
            CargarComboCliente();
            CargarComboPropiedad();
        }

        private void CargarComboPropiedad()
        {
            using (var db = new InmobiliariaContext())
            {
                var listaPropiedades = from propiedades in db.Propiedades
                                        select new { id = propiedades.Id, nombre = propiedades.Nombre};
                //cargamos el combo de tutores con los existentes en la base de datos
                CboPropiedad.DataSource = listaPropiedades.ToList();
                CboPropiedad.DisplayMember = "nombre";
                CboPropiedad.ValueMember = "id";
            }
        }

        private void CargarComboCliente()
        {
            using (var db = new InmobiliariaContext())
            {
                var listaClientes = from cliente in db.Cliente
                                       select new { id = cliente.Id, nombre = cliente.Apellido + " " + cliente.Nombre };
                //cargamos el combo de tutores con los existentes en la base de datos
                CboCliente.DataSource = listaClientes.ToList();
                CboCliente.DisplayMember = "nombre";
                CboCliente.ValueMember = "id";
            }
        }

        private void CargarComboTipoOperacion()
        {
            CboAlquilerVenta.DataSource = Enum.GetValues(typeof(TipoDetalleEnum));
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new InmobiliariaContext())
            {
                detallecompraalquier.TipoDetalle = (TipoDetalleEnum)CboAlquilerVenta.SelectedValue;
                detallecompraalquier.IdCliente = CboCliente.SelectedIndex;
                detallecompraalquier.IdPropiedad = CboPropiedad.SelectedIndex;
                detallecompraalquier.FechaInicio = DtpFechaInicioOVenta.Value.Date;
                detallecompraalquier.FechaFin = DtpFechaFin.Value.Date;
                detallecompraalquier.PrecioAlquiler = (double)NumUpDownAlquiler.Value;
                detallecompraalquier.PrecioVenta = (double)NumUpDownVenta.Value; 

                db.DetalleCompraAlquiler.Add(detallecompraalquier);

                db.SaveChanges();

                MessageBox.Show("La operación fue realizada con exito");
            }
            this.Close();
        }

        private void CboAlquilerVenta_SelectedValueChanged(object sender, EventArgs e)
        {
            try { 
            if ((TipoDetalleEnum)CboAlquilerVenta.SelectedValue == TipoDetalleEnum.Alquier) {
                    LblPrecioVenta.Visible = false;
                    NumUpDownVenta.Visible = false;
                    LblPrecioAlquier.Visible = true;
                    NumUpDownAlquiler.Visible = true;
                    LblFechaDeFin.Visible = true;
                    DtpFechaFin.Visible = true;

                }
            else { 
                LblPrecioVenta.Visible = true;
                NumUpDownVenta.Visible = true;
                LblPrecioAlquier.Visible = false;
                NumUpDownAlquiler.Visible = false;
                LblFechaDeFin.Visible = false;
                DtpFechaFin.Visible = false;
                }
            }
            catch {
               
            }
        }
    }
}

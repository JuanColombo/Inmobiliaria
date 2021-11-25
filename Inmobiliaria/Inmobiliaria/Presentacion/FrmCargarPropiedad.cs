using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Inmobiliaria.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inmobiliaria.Core;

namespace Inmobiliaria.Presentacion
{
    public partial class FrmCargarPropiedad : Form
    {
        //creamos la propiedad para manejar la webcam
        WebCam webcam;
        public int? IdEditar { get; set; }
        Propiedades propiedades = new Propiedades();
        public FrmCargarPropiedad(Propietario propietario)
        {
            InitializeComponent();
            CargarComboPropietario();
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
            CboPropietario.Enabled = false;
            CboPropietario.SelectedValue = propietario.Id;
        }
        public FrmCargarPropiedad()
        {
            InitializeComponent();
            CargarComboPropietario();
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
        }
        public FrmCargarPropiedad(int idSeleccionado)
        {
            InitializeComponent();
            CargarComboPropietario();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDeLaPropiedad();
            }
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
        }
        public FrmCargarPropiedad(Propietario propietario, int idSeleccionado)
        {
            InitializeComponent();
            CargarComboPropietario();
            webcam = new WebCam(this, AutoActivate: false, PbxImagen);
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDeLaPropiedad();
            }
        }

        private void CargarDatosDeLaPropiedad()
        {
            using (var db = new InmobiliariaContext())
            {
                propiedades = db.Propiedades.Find(IdEditar);
                TxtNombre.Text = propiedades.Nombre;
                TxtUbicacion.Text = propiedades.Ubicacion;               
                NumUpDownValor.Value = (decimal)propiedades.Valor;
                ChkDisponible.Checked = propiedades.Disponibilidad;
                CboPropietario.SelectedValue = propiedades.PropietarioId;
                if (propiedades.Imagen != null)
                    PbxImagen.Image = HelperInmobiliaria.convertirBytesAImagen(propiedades.Imagen);

            }
        }

        private void CargarComboPropietario()
        {
            using (var db = new InmobiliariaContext())
            {
                var listaPropietarios = from propietario in db.Propietario
                                   select new { id = propietario.Id, nombre = propietario.Apellido + " " + propietario.Nombre };
                //cargamos el combo de tutores con los existentes en la base de datos
                CboPropietario.DataSource = listaPropietarios.ToList();
                CboPropietario.DisplayMember = "nombre";
                CboPropietario.ValueMember = "id";
            }
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //cerramos el formulario
            this.MensajeDeAdvertenciaDeSalida();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new InmobiliariaContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                propiedades.Nombre = TxtNombre.Text;
                propiedades.Ubicacion = TxtUbicacion.Text;
                propiedades.Valor = (double)NumUpDownValor.Value;
                propiedades.Disponibilidad = ChkDisponible.Checked;
                propiedades.PropietarioId = (int)CboPropietario.SelectedValue;
                //si hay una imagen definida la almacenamos en la propiedad correspondiente
                if (PbxImagen.Image != null)
                {
                    propiedades.Imagen = HelperInmobiliaria.convertirImagenABytes(PbxImagen.Image);
                    BtnCapturarFoto.Enabled = true;
                }
                else
                    BtnCapturarFoto.Enabled = false;
                //si el id del Cliente a editar es nulo agregamos un Cliente Nuevo a la tabla
                if (IdEditar == null)
                    // agregamos el objeto Clientes a la Base De datos
                    db.Propiedades.Add(propiedades);
                else //configuramos el almacenamiento de la modificacion si el id del Cliente es distinto de nulo
                {
                    db.Entry(propiedades).State = EntityState.Modified;
                }
                db.SaveChanges();

                if (IdEditar == null)
                    MessageBox.Show("Propiedad " + propiedades.Nombre + " cargada con exito");
                else
                    MessageBox.Show("Propiedad " + propiedades.Nombre +"  modificada con exito");
                this.Close();

            }
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.gif;*.png;*.bmp;*.jpeg";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|JPEG (*.jpeg)|*.jpeg";
            filtro += "|GIF (*.gif)|*.gif";
            filtro += "|PNG (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";

            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();

            if (ofdAbrirArchivo.FileName != "")
            {
                PbxImagen.Image = new Bitmap(ofdAbrirArchivo.FileName);
            }
        }

        private void BtnIniciarDetenerCamara_Click(object sender, EventArgs e)
        {
            if (BtnIniciarDetenerCamara.Text == "Iniciar cámara")
            {
                InicializarCamara();
            }
            else
            {
                DetenerCamara();
            }
        }

        private void DetenerCamara()
        {
            webcam.Deinitalize();
            BtnIniciarDetenerCamara.Text = "Iniciar cámara";
            BtnCapturarFoto.Text = "Borrar foto";
        }

        private void InicializarCamara()
        {
            webcam.Initalize();
            BtnIniciarDetenerCamara.Text = "Detener cámara";
            BtnCapturarFoto.Text = "Capturar foto";
            //RefrescarPaneles();
            BtnCapturarFoto.Enabled = true;
        }

        private void BtnCapturarFoto_Click_1(object sender, EventArgs e)
        {
            if (BtnCapturarFoto.Text == "Borrar foto")
            {
                PbxImagen.Image = null;
                BtnCapturarFoto.Enabled = false;
            }
            else
                DetenerCamara();
        }
    }
}

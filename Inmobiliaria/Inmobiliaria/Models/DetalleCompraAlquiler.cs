using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inmobiliaria.Models
{
    public class DetalleCompraAlquiler
    {
        public int Id { get; set; }
        [Required]
        public int IdCliente { get; set; }
        public Cliente cliente { get; set; }
        public int IdPropiedad { get; set; }
        public Propiedades Propiedades { get; set; }
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        public double PrecioVenta { get; set; }
       
        public double PrecioAlquiler { get; set; }
       
        public TipoDetalleEnum TipoDetalle { get; set; }
        
    }
}

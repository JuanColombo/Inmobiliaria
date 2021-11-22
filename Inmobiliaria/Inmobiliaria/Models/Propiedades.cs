using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inmobiliaria.Models
{
    public class Propiedades : ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Ubicacion { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public bool Disponibilidad { get; set; }
        [Required]
        public int PropietarioId { get; set; }
        public Propietario Propietario { get; set; }

    }
}

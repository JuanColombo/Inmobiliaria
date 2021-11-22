using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inmobiliaria.Models
{
    public class Propietario : ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int Dni { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required]
        public double Cuil { get; set; }
        [Required]
        public double Cuit { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public double Telefono { get; set; }
        [Required]
        public SexoEnum Sexo { get; set; }
        public string Email { get; set; }
        public EstadoCivilEnum EstadoCivil { get; set; }
        public string Localidad { get; set; }
        [Required]
        public CondicionIvaEnum CondicionIva { get; set; }
        public ICollection<Propiedades> Propiedades { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inmobiliaria.Core;

namespace Inmobiliaria.Models
{
   public class InmobiliariaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(HelperInmobiliaria.ObtenerCadenaDeConexion());

           // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database = InmobiliariaContext; User Id = sa; Password = 1234; MultipleActiveResultSets = True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 2, Nombre = "Juan Pablo", Apellido = "Colombo", Dni = 36196266, Cuil = 20361962665, FechaNacimiento = new DateTime(1992, 1, 17), Telefono = 3498463367, Sexo = SexoEnum.Masculino, Email = "juampicolombosj@gmail.com", EstadoCivil = EstadoCivilEnum.Soltero, Localidad = "San Justo", Domicilio = "Rafael Bonin 2874", CondicionIva = CondicionIvaEnum.Monotributista },
                 new Cliente { Id = 1, Nombre = "Ivan", Apellido = "Valle", Dni = 37454714, Cuil = 20374547144, FechaNacimiento = new DateTime(1993, 6, 29), Telefono = 3498459297, Sexo = SexoEnum.Masculino, Email = "ivanvallesj@gmail.com", EstadoCivil = EstadoCivilEnum.Soltero, Localidad = "San Justo", Domicilio = "Cabal 2608", CondicionIva = CondicionIvaEnum.ConsumidorFinal }
                );
            modelBuilder.Entity<Propietario>().HasData(
                 new Propietario { Id = 1, Nombre = "Julian Daniel", Apellido = "Parra", Dni = 36196259, Cuil = 20361962595, FechaNacimiento = new DateTime(1992, 1, 10), Telefono = 3498526969, Sexo = SexoEnum.Masculino, Email = "inmobiliariajuliandaniel@hotmail.com", EstadoCivil = EstadoCivilEnum.Soltero, Localidad = "San Justo", Domicilio = "Juan Peron y Urquiza", CondicionIva = CondicionIvaEnum.Monotributista }
               );
            modelBuilder.Entity<Propiedades>().HasData(
                  new Propiedades { Id = 1, Nombre = "Propiedad 1", Ubicacion = "Barrio Parque", Valor = 1500000, Disponibilidad = true, PropietarioId = 1 },
                  new Propiedades { Id = 2, Nombre = "Propiedad 2", Ubicacion = "Barrio Levequi", Valor = 800000, Disponibilidad = true, PropietarioId = 1 }
                  );
            modelBuilder.Entity<DetalleCompraAlquiler>().HasData(
                  new DetalleCompraAlquiler { Id = 1, IdCliente = 1, IdPropiedad = 1, FechaInicio = new DateTime(2020, 12, 2), FechaFin = new DateTime(2023, 12, 2), TipoDetalle = TipoDetalleEnum.Alquier, PrecioAlquiler = 15000 },
                  new DetalleCompraAlquiler { Id = 2, IdCliente = 2, IdPropiedad = 2, FechaInicio = new DateTime(2020, 12, 2), FechaFin = new DateTime(2023, 12, 2), TipoDetalle = TipoDetalleEnum.Venta, PrecioVenta = 800000 }
                   );
            modelBuilder.Entity<Usuario>().HasData(
             new Usuario { Id = 1, Nombre ="Juan Pablo Colombo", User = "juan", Password= "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", TipoUsuario = TipoUsuarioEnum.Administrador });


        }
        public DbSet<Propiedades> Propiedades { get; set; }
        public DbSet<Propietario> Propietario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetalleCompraAlquiler> DetalleCompraAlquiler { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        public InmobiliariaContext(DbContextOptions<InmobiliariaContext> options) : base(options)
        {

        }

        public InmobiliariaContext()
        {
        }

    }
}

using Inmobiliaria.Interfaces;
using Inmobiliaria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inmobiliaria.AdminData
{
     class DbAdminClientes : IDbAdmin
    {
        public void Actualizar(object cliente)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object cliente)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            db.Cliente.Add((Cliente)cliente);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            var cliente = db.Cliente.Find(idSeleccionado);

            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            cliente.Eliminado = true;
            cliente.FechaHoraEliminacion = DateTime.Now;
            cliente.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using InmobiliariaContext db = new InmobiliariaContext();
            return db.Cliente.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            return db.Cliente.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            return db.Cliente.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using InmobiliariaContext db = new InmobiliariaContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Cliente.Where(c => c.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            var cliente = db.Cliente.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            cliente.Eliminado = false;
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

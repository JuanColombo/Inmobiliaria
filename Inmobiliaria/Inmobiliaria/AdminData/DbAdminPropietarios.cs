using Inmobiliaria.Interfaces;
using Inmobiliaria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inmobiliaria.AdminData
{
    class DbAdminPropietarios : IDbAdmin
    {
        public void Actualizar(object propietario)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            db.Entry(propietario).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object propietario)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            db.Propietario.Add((Propietario)propietario);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            var propietario = db.Propietario.Find(idSeleccionado);
            
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            propietario.Eliminado = true;
            propietario.FechaHoraEliminacion = DateTime.Now;
            propietario.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(propietario).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using InmobiliariaContext db = new InmobiliariaContext();
            return db.Propietario.Find(idObtener);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            return db.Propietario.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTodos()
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            return db.Propietario.Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using InmobiliariaContext db = new InmobiliariaContext();
            ////consultamos en la cadena buscada si contiene la expresion
            return db.Propietario.Where(c => c.Nombre.Contains(cadenaBuscada)).Include(u => u.Usuario).IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList().ToList();
        }

        public void Restaurar(int idSeleccionado)
        {
            using InmobiliariaContext db = new InmobiliariaContext();
            var propietario = db.Propietario.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            propietario.Eliminado = false;
            db.Entry(propietario).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

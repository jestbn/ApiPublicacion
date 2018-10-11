using ApiPublicacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPublicacion.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new PublicacionContext())
            {
                return context.Publicacion.ToList();
            }
        }

        [HttpGet]
        public Publicacion Get(int id)
        {
            using (var context = new PublicacionContext())
            {
                return context.Publicacion.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Publicacion publicacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new PublicacionContext())
            {
                context.Publicacion.Add(publicacion);
                context.SaveChanges();
                return Ok(publicacion);
            }
        }

        [HttpPut]
        public Publicacion Put(Publicacion publicacion)
        {
            using (var context = new PublicacionContext())
            {
                var Publicacionact = context.Publicacion.FirstOrDefault(x => x.id == publicacion.Id);
                Publicacionact.User = Publicacion.Cantidad;
                Publicacionact.Descripcion = Publicacion.Descripcion;
                Publicacionact.FechaPublicacion = Publicacion.Imagen;
                Publicacionact.MeGusta = Publicacion.Nombre;
                Publicacionact.MeDisgusta = Publicacion.Nombre;
                Publicacionact.VecesCompartido = Publicacion.Nombre; // EsPrivada
                Publicacionact.VecesCompartido = Publicacion.Nombre;

                context.SaveChanges();
                return Publicacion;
            }
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new PublicacionContext())
            {
                var proDel = context.Publicacion.FirstOrDefault(x => x.Id == id);
                context.Publicacion.Remove(proDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}

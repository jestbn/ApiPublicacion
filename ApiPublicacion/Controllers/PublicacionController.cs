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
                var Publicacionact = context.Publicacion.FirstOrDefault(x => x.Id == publicacion.Id);
                Publicacionact.User = publicacion.User;
                Publicacionact.Descripcion = publicacion.Descripcion;
                Publicacionact.FechaPublicacion = publicacion.FechaPublicacion;
                Publicacionact.MeGusta = publicacion.MeGusta;
                Publicacionact.MeDisgusta = publicacion.MeDisgusta;
                Publicacionact.VecesCompartido = publicacion.VecesCompartido;
                Publicacionact.EsPrivada = publicacion.EsPrivada;

                context.SaveChanges();
                return publicacion;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ApiPublicacion.Models
{
    public class PublicacionContext : DbContext
    {
        public PublicacionContext(): base ("PublicacionConnection")
        {

        }
        public DbSet<Publicacion> Publicacion { get; set; }
    }
}
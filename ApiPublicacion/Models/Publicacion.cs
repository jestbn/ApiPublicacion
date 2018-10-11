using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApiPublicacion.Models
{
    [Table ("Publicacions")]
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string User { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        public int MeGusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
        [Required]
        public bool EsPrivada { get; set; }
    }
}
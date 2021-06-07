using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConfisaTest.Models
{
    public class Dealers
    {
        [Key]
        public int id { get; set; }
        public string rnc { get; set; }
        public string Nombre { get; set; }
        public string dirección { get; set; }
        public string teléfono { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
        [ForeignKey("Oficial")]
        public int idOficial { get; set; }
        public Oficiales Oficial { get; set; }
    }
}

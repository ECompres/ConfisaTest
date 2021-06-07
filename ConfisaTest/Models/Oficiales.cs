using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfisaTest.Models
{
    public class Oficiales
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Dealers> Dealers { get; set; }
        
    }
}

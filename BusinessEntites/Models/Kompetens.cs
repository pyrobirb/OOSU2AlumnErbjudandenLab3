using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;

namespace BusinessEntites.Models
{
    public class Kompetens : IKompetens
    {
        [Key]
        public string KompetensID { get; set; }
        public string Beskrivning { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;

namespace BusinessEntites.Models
{
    public class Informationsutskick : IInformationsutskick
    {
        [Key]
        public string UtskicksID { get; set; }
        public DateTime UtskickDatum { get; set; }

        public virtual ICollection<Alumn> Utskickslista { get; set; }
        
    }
}

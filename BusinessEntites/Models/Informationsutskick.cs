using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;
using BusinessEntites.Models.Junction;

namespace BusinessEntites.Models
{
    public class Informationsutskick : IInformationsutskick
    {
        [Key]
        public int UtskicksID { get; set; }
        public DateTime UtskickDatum { get; set; }
        public ICollection<Alumn> Utskickslista { get; set; }
        public ICollection<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;

namespace BusinessEntites.Models
{
    public class Informationsutskick : IInformationsutskick
    {
        public DateTime UtskickDatum { get; set; }

        public virtual ICollection<Alumn> Utskickslista { get; set; }
        public string UtskicksID { get; set; }
    }
}

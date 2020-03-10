using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnMaillistaDTO : IAlumnMaillistaDTO
    {
        public int AlumnID { get; set; }
        public virtual AlumnDTO Alumn { get; set; }

        public int MaillistaID { get; set; }
        public virtual MaillistaDTO Maillista { get; set; }
    }
}

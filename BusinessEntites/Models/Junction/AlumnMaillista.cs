using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnMaillista : IAlumnMaillista
    {
        public int AlumnID { get; set; }
        public virtual Alumn Alumn { get; set; }

        public int MaillistaID { get; set; }
        public virtual Maillista Maillista { get; set; }
    }
}

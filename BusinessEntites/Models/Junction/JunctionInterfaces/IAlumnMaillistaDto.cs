using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    interface IAlumnMaillistaDTO
    {
        int AlumnID { get; set; }
        AlumnDTO Alumn { get; set; }

        int MaillistaID { get; set; }
        MaillistaDTO Maillista { get; set; }
    }
}

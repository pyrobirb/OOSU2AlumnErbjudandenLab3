using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    interface IAlumnMaillistaDto
    {
        int AlumnID { get; set; }
        AlumnDto Alumn { get; set; }

        int MaillistaID { get; set; }
        MaillistaDto Maillista { get; set; }
    }
}

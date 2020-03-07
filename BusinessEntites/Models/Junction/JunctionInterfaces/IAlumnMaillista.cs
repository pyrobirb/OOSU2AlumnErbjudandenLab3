using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    interface IAlumnMaillista
    {
        int AlumnID { get; set; }
        Alumn Alumn { get; set; }

        int MaillistaID { get; set; }
        Maillista Maillista { get; set; }
    }
}

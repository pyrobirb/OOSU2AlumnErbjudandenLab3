using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    interface IMaillista
    {
        int MaillistaID { get; set; }
        string MaillistaNamn { get; set; }
        ICollection<AlumnMaillista> AlumnMaillistor { get; set; }
    }
}

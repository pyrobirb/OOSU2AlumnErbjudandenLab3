using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    interface IMaillistaDto
    {
        int MaillistaID { get; set; }
        string MaillistaNamn { get; set; }
        ICollection<AlumnMaillistaDto> AlumnMaillistor { get; set; }
    }
}

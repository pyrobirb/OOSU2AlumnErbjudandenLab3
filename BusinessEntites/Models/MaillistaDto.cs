using BusinessEntites.Models.Interfaces;
using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models
{
    public class MaillistaDTO : IMaillistaDTO
    {
        [Key]
        public int MaillistaID { get; set; }
        public string MaillistaNamn { get; set; }
        public virtual ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }
    }
}

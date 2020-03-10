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
    public class PersonalDto : IPersonalDto
    {
        [Key]
        public int PersonalID { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public virtual ICollection<PersonalInformationsutskickDto> PersonalInformationsutskick { get; set; }
    }
}

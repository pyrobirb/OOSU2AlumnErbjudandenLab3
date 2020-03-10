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
    public class AlumnDto : IAlumnDto
    {   
        [Key]
        public int AnvändarID { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }

        public virtual ICollection<AlumnProgramDto> AlumnProgram { get; set; }
        public virtual ICollection<AlumnKompetensDto> AlumnKompetens { get; set; }
        public virtual ICollection<InformationsutskickAlumnDto> InformationsutskickAlumn { get; set; }
        public virtual ICollection<AlumnAktivitetBokningDto> AlumnAktivitet { get; set; }
        public virtual ICollection<AlumnMaillistaDto> AlumnMaillistor { get; set; }
    }
}

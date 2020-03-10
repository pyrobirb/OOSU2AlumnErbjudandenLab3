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
    public class AlumnDTO : IAlumnDTO
    {   
        [Key]
        public int AnvändarID { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }

        public virtual ICollection<AlumnProgramDTO> AlumnProgram { get; set; }
        public virtual ICollection<AlumnKompetensDTO> AlumnKompetens { get; set; }
        public virtual ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        public virtual ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }
        public virtual ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }
    }
}

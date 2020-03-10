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
    public class AktivitetDTO : IAktivitetDTO
    {   [Key]
        public int AktivitetsID { get; set; }
        public string Titel { get; set; }
        public string Kontaktperson { get; set; }
        public string Ansvarig { get; set; }
        public string Plats { get; set; }
        public DateTime Startdatum { get; set; }
        public DateTime Slutdatum { get; set; }
        public string Beskrivning { get; set; }
        public virtual ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }
        public virtual ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }

    }
}

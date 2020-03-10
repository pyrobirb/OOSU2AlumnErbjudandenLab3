using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IAlumnDTO
    {
        int AnvändarID { get; set; }
        string Förnamn { get; set; }
        string Efternamn { get; set; }
        string Användarnamn { get; set; }
        string Lösenord { get; set; }

        ICollection<AlumnProgramDTO> AlumnProgram { get; set; }

        ICollection<AlumnKompetensDTO> AlumnKompetens { get; set; }

        ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }

        ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }

        ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }
    }
}

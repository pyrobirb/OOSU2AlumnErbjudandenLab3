using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IAlumnDto
    {
        int AnvändarID { get; set; }
        string Förnamn { get; set; }
        string Efternamn { get; set; }
        string Användarnamn { get; set; }
        string Lösenord { get; set; }

        ICollection<AlumnProgramDto> AlumnProgram { get; set; }

        ICollection<AlumnKompetensDto> AlumnKompetens { get; set; }

        ICollection<InformationsutskickAlumnDto> InformationsutskickAlumn { get; set; }

        ICollection<AlumnAktivitetBokningDto> AlumnAktivitet { get; set; }

        ICollection<AlumnMaillistaDto> AlumnMaillistor { get; set; }
    }
}

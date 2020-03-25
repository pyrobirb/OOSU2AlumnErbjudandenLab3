using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Interfaces
{
    public interface IAlumn
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");

        bool Spara(Alumn alumn);
        ICollection<AlumnProgramDTO> AlumnProgram { get; set; }
        ICollection<AlumnKompetensDTO> AlumnKompetens { get; set; }
        ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }
        ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }

        int AnvändarID { get; set; }
        string Användarnamn { get; set; }
        string Lösenord { get; set; }
        string Förnamn { get; set; }
        string Efternamn { get; set; }
    }
}

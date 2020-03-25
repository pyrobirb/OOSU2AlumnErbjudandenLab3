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
    public interface IInformationsutskick
    {

        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");

        int utskicksID { get; set; }
        string utskicksNamn { get; set; }
        DateTime utskickDatum { get; set; }
        ICollection<Alumn> Alumner { get; set; }
        ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        ICollection<PersonalInformationsutskickDTO> PersonalInformationsutskick { get; set; }
        ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }

        int UtskicksID { get; set; }
        string UtskicksNamn { get; set; }
        DateTime UtskickDatum { get; set; }
    }
}
